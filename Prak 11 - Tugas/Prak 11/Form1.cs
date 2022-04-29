using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Security.Cryptography;

namespace Prak_11
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
        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void kPengrim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encryptbtn_Click(object sender, EventArgs e)
        {
            string pText = plainText.Text;
            int plainTextLength = pText.Length;
            int kunciPengirim = Convert.ToInt32(kPengrim.Text);
            char ch;
            SenderEncrypt.Text = "";
            receiveEncrypt.Text = "";
            for (int i = 0; i < plainTextLength; i++)
            {
                ch = (char)(pText[i] ^ kunciPengirim);
                SenderEncrypt.Text += ch.ToString();
            }
            receiveEncrypt.Text = SenderEncrypt.Text;
        }

        private void receiveEncrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string eText = receiveEncrypt.Text;
            int encryptedTextLength = eText.Length;
            int kunciPenerima = Convert.ToInt32(kPenerima.Text);
            char ch;
            DecryptTxt.Text = "";
            for (int i = 0; i < encryptedTextLength; i++)
            {
                ch = (char)(eText[i] ^ kunciPenerima);
                DecryptTxt.Text += ch.ToString();
            }
        }
    }
}
