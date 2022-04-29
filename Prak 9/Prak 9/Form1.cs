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

namespace Prak_9
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

        private void timer1_Tick(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                clrTxt.Enabled = true;
            }
            else
            {
                clrTxt.Enabled = false;
            }
        }

        private void SlctFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
                SelectedFilePath.Text = folderBrowserDialog1.SelectedPath;

            if(folderBrowserDialog1.SelectedPath != null)
            {
                textBox1.Enabled = true;
                savingbtn.Enabled = true;
            }
        }

        private void SelectedFilePath_Click(object sender, EventArgs e)
        {

        }

        private void savingbtn_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(SelectedFilePath.Text + "/data.txt", true);
            txt.WriteLine(textBox1.Text);
            txt.Close();
            textBox1.Clear();
        }

        private void clrTxt_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
