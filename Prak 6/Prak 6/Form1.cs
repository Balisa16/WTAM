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

namespace Prak_6
{
    public partial class Form1 : MaterialForm
    {
        private string kata = "";
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void PortName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PortName_Click(object sender, EventArgs e)
        {
            try
            {
                PortName.Items.Clear();
                String[] portList = System.IO.Ports.SerialPort.GetPortNames();
                foreach (String portName in portList)
                    PortName.Items.Add(portName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
            
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            if(connectbtn.Text == "Connect")
            {
                try
                {
                    serialPort1.PortName = PortName.Text;
                    serialPort1.BaudRate = int.Parse(Baudrate.Text);
                    serialPort1.Open();
                    suhubox.Enabled = true;
                    kelembapanbox.Enabled = true;
                    UVindexbox.Enabled = true;
                    tekananbox.Enabled = true;
                    listReceived.Enabled = true;
                    connectbtn.Text = "Disconnect";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    suhubox.Enabled = false;
                    kelembapanbox.Enabled = false;
                    UVindexbox.Enabled = false;
                    tekananbox.Enabled = false;
                    listReceived.Enabled = false;
                    connectbtn.Text = "Connect";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Tampilkan(serialPort1.ReadExisting());
        }
        private delegate void TampilkanDelegate(object item);
        private void Tampilkan(object item)
        {
            if (InvokeRequired)
                listReceived.Invoke(new TampilkanDelegate(Tampilkan), item);
            else
            {
                kata = item + " at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond;
                listReceived.Items.Add(kata);
                splitData(item);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                MessageBox.Show("Port is Open. Please disconnect");
            }
            else
            {
                try
                {
                    DestroyHandle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
        }
        private void splitData(object item)
        {
            String[] data = item.ToString().Split(',');
            suhubox.Text = data[1]; // textbox untuk data suhu
            kelembapanbox.Text = data[2]; // textbox untuk data kelembaban
            tekananbox.Text = data[3]; // textbox untuk data tekanan udara
            UVindexbox.Text = data[4]; // textbox untuk data uv index 
        }

    }
}
