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
            Temp_Request.Enabled = false;
            Kelembapan_Request.Enabled = false;
            Pressure_Request.Enabled = false;
            UV_Request.Enabled = false;
            All_Request.Enabled = false;
        }

        private string dT, dH, dP, dU;
        private bool broadcast = true;

        private FolderBrowserDialog folderDlg = new FolderBrowserDialog();

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
                    //serialPort1.NewLine = "#setop#";
                    serialPort1.NewLine = "\r\n";
                    serialPort1.Open();
                    suhubox.Enabled = true;
                    kelembapanbox.Enabled = true;
                    UVindexbox.Enabled = true;
                    tekananbox.Enabled = true;
                    listReceived.Enabled = true;
                    materialButton2.Enabled = true;
                    stop.Enabled = true;
                    send_msgbox.Enabled = true;
                    send_msg.Enabled = true;
                    delete_msg.Enabled =true;
                    Temp_Request.Enabled = true;
                    Kelembapan_Request.Enabled = true;
                    Pressure_Request.Enabled = true;
                    UV_Request.Enabled = true;
                    All_Request.Enabled = true;
                    checkBox1.Enabled = true;
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
                    materialButton2.Enabled = false;
                    stop.Enabled = false;
                    connectbtn.Text = "Connect";
                    send_msgbox.Enabled = false;
                    send_msg.Enabled = false;
                    delete_msg.Enabled = false;
                    Temp_Request.Enabled = false;
                    Kelembapan_Request.Enabled = false;
                    Pressure_Request.Enabled = false;
                    UV_Request.Enabled = false;
                    All_Request.Enabled = false;
                    checkBox1.Enabled = false;
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
        TextWriter txt;
        private void Tampilkan(object item)
        {
            if (InvokeRequired)
                listReceived.Invoke(new TampilkanDelegate(Tampilkan), item);
            else
            {
                try
                {
                    splitData(item);
                    kata = item + " at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond;
                    listReceived.Items.Add(kata);
                    if(checkBox1.Checked && filePath.Text != "")
                    {
                        if (fileCostumeName.Text == "")
                        {
                            txt = new StreamWriter(filePath.Text + "/data.txt", true);
                        }
                        else
                            txt = new StreamWriter(filePath.Text + "/" + fileCostumeName.Text + ".txt", true);
                        txt.WriteLine("Time  " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond);
                        if(broadcast == true)
                            txt.WriteLine("Mode Broadcast");
                        else
                            txt.WriteLine("Mode Request");
                        if (dT != "")
                            txt.WriteLine("Temperatur   : " + dT);
                        if (dH != "")
                            txt.WriteLine("Humidity     : " + dH);
                        if (dP != "")
                            txt.WriteLine("Air Pressure : " + dP);
                        if (dU != "")
                            txt.WriteLine("UV-Index     : " + dU);
                        txt.WriteLine("");
                        txt.Close();
                    }
                }
                catch
                {
                    listReceived.Items.Add(item);
                }
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
            if(stop.Text == "Stop")
            {
                try
                {
                    //Pendeteksi Error
                    int a = int.Parse(data[2]);
                    if (trigger == 0)
                    {
                        suhubox.Text = data[1];
                        kelembapanbox.Text = data[2];
                        tekananbox.Text = data[3];
                        UVindexbox.Text = data[4];
                        dT = Convert.ToString(data[1]);
                        dH = Convert.ToString(data[2]);
                        dP = Convert.ToString(data[3]);
                        dU = Convert.ToString(data[4]);
                        broadcast = true;
                    }
                    else if (trigger == 1)
                    {
                        suhubox.Text = data[1];
                        kelembapanbox.Text = "";
                        tekananbox.Text = "";
                        UVindexbox.Text = "";
                        dT = Convert.ToString(data[1]);
                        dH = "";
                        dP = "";
                        dU = "";
                        broadcast = true;
                    }
                    else if (trigger == 2)
                    {
                        suhubox.Text = "";
                        kelembapanbox.Text = data[2];
                        tekananbox.Text = "";
                        UVindexbox.Text = "";
                        dT = "";
                        dH = Convert.ToString(data[2]);
                        dP = "";
                        dU = "";
                        broadcast = true;
                    }
                    else if (trigger == 3)
                    {
                        suhubox.Text = "";
                        kelembapanbox.Text = "";
                        tekananbox.Text = data[3];
                        UVindexbox.Text = "";
                        dT = "";
                        dH = "";
                        dP = Convert.ToString(data[3]);
                        dU = "";
                        broadcast = true;
                    }
                    else
                    {
                        suhubox.Text = "";
                        kelembapanbox.Text = "";
                        tekananbox.Text = "";
                        UVindexbox.Text = data[4];
                        dT = "";
                        dH = "";
                        dP = "";
                        dU = Convert.ToString(data[4]);
                        broadcast = true;
                    }
                }
                catch
                {
                    if (trigger == 0)
                    {
                        suhubox.Text = data[1];
                        kelembapanbox.Text = data[2];
                        tekananbox.Text = data[3];
                        UVindexbox.Text = data[4];
                        dT = Convert.ToString(data[1]);
                        dH = Convert.ToString(data[2]);
                        dP = Convert.ToString(data[3]);
                        dU = Convert.ToString(data[4]);
                        broadcast = false;
                    }
                    else if (trigger == 1)
                    {
                        suhubox.Text = data[1];
                        kelembapanbox.Text = "";
                        tekananbox.Text = "";
                        UVindexbox.Text = "";
                        dT = Convert.ToString(data[1]);
                        dH = "";
                        dP = "";
                        dU = "";
                        broadcast = false;
                    }
                    else if (trigger == 2)
                    {
                        suhubox.Text = "";
                        kelembapanbox.Text = data[1];
                        tekananbox.Text = "";
                        UVindexbox.Text = "";
                        dT = "";
                        dH = Convert.ToString(data[1]);
                        dP = "";
                        dU = "";
                        broadcast = false;
                    }
                    else if (trigger == 3)
                    {
                        suhubox.Text = "";
                        kelembapanbox.Text = "";
                        tekananbox.Text = data[1];
                        UVindexbox.Text = "";
                        dT = "";
                        dH = "";
                        dP = Convert.ToString(data[1]);
                        dU = "";
                        broadcast = false;
                    }
                    else
                    {
                        suhubox.Text = "";
                        kelembapanbox.Text = "";
                        tekananbox.Text = "";
                        UVindexbox.Text = data[1];
                        dT = "";
                        dH = "";
                        dP = "";
                        dU = Convert.ToString(data[1]);
                        broadcast = false;
                    }
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            listReceived.Items.Clear();
            Sending_msg.Items.Clear();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (stop.Text == "Stop")
                stop.Text = "Start";
            else
                stop.Text = "Stop";
        }

        private void send_msg_Click(object sender, EventArgs e)
        {
            if(send_msgbox.Text != "")
            {
                try
                {
                    serialPort1.WriteLine(send_msgbox.Text);
                    Sending_msg.Items.Add(send_msgbox.Text);
                    send_msgbox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can`t Send");
                }
            }
            else
            {
                MessageBox.Show("Message is blank. Please Fill your message", "Warning");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sending_msg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int trigger = 0;

        private void delete_msg_Click(object sender, EventArgs e)
        {
            send_msgbox.Clear();
        }

        private void Temp_Request_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("T");
            trigger = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Kelembapan_Request_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("H");
            trigger = 2;
        }

        private void Pressure_Request_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("P");
            trigger = 3;
        }

        private void UV_Request_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("U");
            trigger = 4;
        }

        private void All_Request_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("A");
            trigger = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileCostumeName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Enabled = true;
                fileCostumeName.Enabled = true;
                SlctFilePath.Enabled = true;
                filePath.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                fileCostumeName.Enabled = false;
                SlctFilePath.Enabled = false;
                filePath.Enabled = false;
            }
        }

        private void SlctFilePath_Click_1(object sender, EventArgs e)
        {
            try
            {
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                    filePath.Text = folderDlg.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning !!!");
            }
        }

        private void filePath_Click(object sender, EventArgs e)
        {

        }

        private void fileCostumeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
