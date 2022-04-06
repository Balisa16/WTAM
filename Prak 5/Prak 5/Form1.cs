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
using System.IO.Ports;

namespace Prak_5
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
            indicatorColor.BackColor = Color.Red;
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                PortName.Items.Add(portName);
        }

        private void indicatorColor_Click(object sender, EventArgs e)
        {

        }

        private void Baud_Rate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PortName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            if (Connectbtn.Text == "Connect")
            {
                try
                {
                    serialPort1.PortName = PortName.Text;
                    serialPort1.BaudRate = int.Parse(Baud_Rate.Text);
                    serialPort1.Open();
                    Connectbtn.Text = "Disconnect";
                    indicatorColor.BackColor = Color.Green;
                    Portstatus.Text = "Port : " + PortName.Text;
                    baudratestatus.Text = "Baud Rate : " + Baud_Rate.Text;
                    sendbtn.Enabled = true;
                    sendtxt.Enabled = true;
                    boxview.Enabled = true;
                    clearbtn.Enabled = true;
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
                    Connectbtn.Text = "Connect";
                    indicatorColor.BackColor = Color.Red;
                    Portstatus.Text = "Port : -";
                    baudratestatus.Text = "Baud Rate : -";
                    sendbtn.Enabled = false;
                    sendtxt.Enabled = false;
                    boxview.Enabled = false;
                    clearbtn.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning");
                }
            }
        }

        private void Portstatus_Click(object sender, EventArgs e)
        {

        }

        private void baudratestatus_Click(object sender, EventArgs e)
        {

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(sendtxt.Text);
                boxview.Items.Add(DateTime.Now + " You : " + sendtxt.Text);
                sendtxt.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void sendtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            boxview.Items.Clear();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                MessageBox.Show("Port is Open. Please Disconnect before leave");
            }
            else
            {
                DestroyHandle();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Tampilkan(serialPort1.ReadExisting());
        }
        private delegate void TampilkanDelegate(object item);
        private void Tampilkan(object item)
        {
            if (InvokeRequired)
                boxview.Invoke(new TampilkanDelegate(Tampilkan), item);
            else
                boxview.Items.Add("- - >" + DateTime.Now + " Reply : " + item);
        }

    }
}
