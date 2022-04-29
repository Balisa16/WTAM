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
using System.IO;

namespace Prak_10
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void COMPort_Click(object sender, EventArgs e)
        {
            try
            {
                COMPortlist.Items.Clear();
                String[] portList = System.IO.Ports.SerialPort.GetPortNames();
                foreach (String portName in portList)
                    COMPortlist.Items.Add(portName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            if (Connectbtn.Text == "Connect")
            {
                try
                {
                    serialPort1.PortName = COMPortlist.Text;
                    serialPort1.BaudRate = int.Parse(baudratelist.Text);
                    Connectbtn.Text = "Disconnect";
                    serialPort1.NewLine = "\r\n";
                    serialPort1.Open();
                    selectFile.Enabled = true;
                    sendBtn.Enabled = true;
                    SelectedFilelbl.Enabled = true;
                    listBox1.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    selectFile.Enabled = false;
                    sendBtn.Enabled = false;
                    SelectedFilelbl.Enabled = false;
                    listBox1.Enabled = false;
                    Connectbtn.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch { }
            DestroyHandle();
        }

        private string NamaFile;

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                NamaFile = openFileDialog1.FileName;
                SelectedFilelbl.Text = NamaFile;
                FileInfo inpo = new FileInfo(NamaFile);
                long ukuran = inpo.Length;
                fileInpo.Items.Clear();
                fileInpo.Items.Add("File Name\t\t: " + inpo.Name);
                if(ukuran < 1000)
                    fileInpo.Items.Add("Size\t\t: " + Convert.ToString(ukuran) + " byte");
                else if(ukuran >= 1000 && ukuran < 1000000)
                {
                    ukuran = ukuran / 1000;
                    fileInpo.Items.Add("Size\t\t: " + ukuran.ToString("0.00") + " kB");
                }
                else if (ukuran >= 1000000 && ukuran < 1000000000)
                {
                    ukuran = ukuran / 1000000;
                    fileInpo.Items.Add("Size\t\t: " + ukuran.ToString("0.00") + " MB");
                }
                else
                {
                    ukuran = ukuran / 1000000000;
                    fileInpo.Items.Add("Size\t\t: " + ukuran.ToString("0.00") + " GB");
                }
                fileInpo.Items.Add("Create Time\t: " + inpo.CreationTime);
                fileInpo.Items.Add("Ekstension\t: " + inpo.Extension);
                fileInpo.Items.Add("Atributes\t\t: " + inpo.Attributes);
                fileInpo.Items.Add("Last Access\t: " + inpo.LastAccessTime);
                fileInpo.Items.Add("Last Write\t: " + inpo.LastWriteTime);
                fileInpo.Items.Add("Directory\t\t: " + inpo.Directory);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string baris;
                int counter = 0;
                int j_huruf = 0;
                string kalimat_baris;
                listBox1.Items.Clear();
                TextReader txt = new StreamReader(SelectedFilelbl.Text);
                while ((baris = txt.ReadLine()) != null)
                {
                    listBox1.Items.Add(baris);
                    counter++;
                    serialPort1.WriteLine(baris);
                    kalimat_baris = baris;
                    foreach(char chr in kalimat_baris)
                    {
                        j_huruf++;
                        if(chr == ' ')
                            j_huruf--;
                    }
                }
                txt.Close();
                string J_Karakter = Convert.ToString(File.ReadAllBytes(NamaFile));
                MessageBox.Show("Done sending " + Convert.ToString(counter) + " rows"
                    + " and " + j_huruf + " character"
                    , "Sucessfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning !!!");
            }
        }

        private void PropertiesFile_Click(object sender, EventArgs e)
        {

        }
    }
}
