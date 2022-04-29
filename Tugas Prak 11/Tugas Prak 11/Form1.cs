using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Tugas_Prak_11
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        byte[] savingdataEncription;
        byte[] GlobalKey;
        byte[] GlobalIV;

        private void Encryptbtn_Click(object sender, EventArgs e)
        {
            string sendingMessage = senderText.Text;
            using (Aes myAes = Aes.Create())
            {
                GlobalKey = myAes.Key;
                GlobalIV = myAes.IV;
                savingdataEncription = EncryptStringToBytes_Aes(sendingMessage, GlobalKey, GlobalIV);
                senderEncrypted.Text = Encoding.ASCII.GetString(savingdataEncription);
                //Bisa juga
                /*senderEncrypted.Text = BitConverter.ToString(savingdataEncription);*/
                receiveEncrypted.Text = senderEncrypted.Text;
            }

        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void Decryptbtn_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                /*byte[] DecryptData = Encoding.ASCII.GetBytes(receiveEncrypted.Text);*/
                byte[] DecryptData = savingdataEncription;
                string roundtrip = DecryptStringFromBytes_Aes(DecryptData, GlobalKey, GlobalIV);
                DecryptedResult.Text = roundtrip;
            }
        }
    }
}
