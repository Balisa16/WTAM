using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

/*
Nama        : Sander Antonius Balisa
Kelas       : 2 D4 EB
NRP         : 2120600053

Workshop Teknik Antarmuka
 */

namespace GUI_1
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
            chart1.ChartAreas[0].BorderColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].BackColor = Color.Black;
            chart1.ChartAreas[0].AxisX.Title = "Time (ms)";
            chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";


            chart1.BackColor = Color.Black;
            chart1.Legends[0].BackColor = Color.Black;
            chart1.Legends[0].ForeColor = Color.White;
            chart1.BorderlineColor = Color.White;
            chart1.BorderSkin.BorderColor = Color.White;

            thick = 1;
            time_increase = 0.001;
            Axis_y_title = "Voltage (V)";

            chart1.Series[0].Name = "Sinyal 1";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = thick;
            chart1.Series[0].Color = Color.Red;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            chart1.Series.Add("Sinyal 2");
            chart1.Series["Sinyal 2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sinyal 2"].BorderWidth = thick;
            chart1.Series["Sinyal 2"].Color = Color.Green;

            chart1.Series.Add("Sinyal 3");
            chart1.Series["Sinyal 3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sinyal 3"].BorderWidth = thick;
            chart1.Series["Sinyal 3"].Color = Color.Blue;
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Amp1.Text == "")
                amplitude1 = 0;
            else
                amplitude1 = double.Parse(Amp1.Text)*t_Amp1;
            if (Amp2_tbox.Text == "")
                amplitude2 = 0;
            else
                amplitude2 = double.Parse(Amp2_tbox.Text) * t_Amp2;
            if (Amp3_tbox.Text == "")
                amplitude3 = 0;
            else
                amplitude3 = double.Parse(Amp3_tbox.Text) * t_Amp3;

            if (Freq1_tbox.Text == "")
                frequency1 = 0;
            else
                frequency1 = double.Parse(Freq1_tbox.Text) * k_freq1;
            if (Freq2_tbox.Text == "")
                frequency2 = 0;
            else
                frequency2 = double.Parse(Freq2_tbox.Text) * k_freq2;
            if (Freq3_tbox.Text == "")
                frequency3 = 0;
            else
                frequency3 = double.Parse(Freq3_tbox.Text) * k_freq3;

            double y1 = amplitude1 * Math.Sin(2 * Math.PI * frequency1 * time);
            double y2 = amplitude2 * Math.Sin(2 * Math.PI * frequency2 * time);
            double y3 = amplitude3 * Math.Sin(2 * Math.PI * frequency3 * time);

            if (time_interval_box.Text == "")
                time_interval = 100;
            else
                time_interval = double.Parse(time_interval_box.Text);
            time_sc = time_scale.Text;


            if (time_sc == "ms")
                chart1.ChartAreas[0].AxisX.Title = "Time (ms)";
            else if (time_sc == "us")
                chart1.ChartAreas[0].AxisX.Title = "Time (us)";
            else if (time_sc == "ns")
                chart1.ChartAreas[0].AxisX.Title = "Time (ns)";
            else if (time_sc == "ps")
                chart1.ChartAreas[0].AxisX.Title = "Time (ps)";
            else
                chart1.ChartAreas[0].AxisX.Title = "Time (s)";

            chart1.ChartAreas[0].AxisY.Title = Axis_y_title;

            chart1.Series[0].Points.AddXY(time, y1);
            chart1.Series["Sinyal 2"].Points.AddXY(time, y2);
            chart1.Series["Sinyal 3"].Points.AddXY(time, y3);
            time += time_increase;

            /*if (chart1.Series[0].Points.Count > time_interval)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series["Sinyal 2"].Points.RemoveAt(0);
                chart1.Series["Sinyal 3"].Points.RemoveAt(0);
            }*/
            if (chart1.Series[0].Points.Count > time_interval)
            {
                chart1.ChartAreas[0].AxisX.Minimum = time - (time_increase * time_interval);
                chart1.ChartAreas[0].AxisX.Maximum = time;
            }
        }
        
        private double time = 0.0;
        private double amplitude1 = 0, amplitude2 = 0, amplitude3 = 0;
        private double frequency1 = 0, frequency2 = 0, frequency3 = 0;
        private int thick;
        private double time_interval, time_increase, t_Amp1, t_Amp2, t_Amp3;
        private string time_sc, Axis_y_title;
        private int k_freq1, k_freq2, k_freq3;

        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);

            if (satuan_Amp1.Text == "GV" && Amp2_scale.Text == "GV" && sinyal3_tbox.Text == "GV")
                Axis_y_title = "Giga Voltage (GV)";
            else if (satuan_Amp1.Text == "MV" && Amp2_scale.Text == "MV" && sinyal3_tbox.Text == "MV")
                Axis_y_title = "Mega Voltage (MV)";
            else if (satuan_Amp1.Text == "kV" && Amp2_scale.Text == "kV" && sinyal3_tbox.Text == "kV")
                Axis_y_title = "kilo Voltage (kV)";
            else if (satuan_Amp1.Text == "mV" && Amp2_scale.Text == "mV" && sinyal3_tbox.Text == "mV")
                Axis_y_title = "mili Voltage (mV)";
            else if (satuan_Amp1.Text == "uV" && Amp2_scale.Text == "uV" && sinyal3_tbox.Text == "uV")
                Axis_y_title = "mikro Voltage (uV)";
            else if (satuan_Amp1.Text == "nV" && Amp2_scale.Text == "nV" && sinyal3_tbox.Text == "nV")
                Axis_y_title = "nano Voltage (nV)";
            else if (satuan_Amp1.Text == "pV" && Amp2_scale.Text == "pV" && sinyal3_tbox.Text == "pV")
                Axis_y_title = "piko Voltage (pV)";
            else
            {
                Axis_y_title = "Voltage (V)";
                if (satuan_Amp1.Text == "GV")
                    t_Amp1 = 1000000000;
                else if (satuan_Amp1.Text == "MV")
                    t_Amp1 = 1000000;
                else if (satuan_Amp1.Text == "kV")
                    t_Amp1 = 1000;
                else if (satuan_Amp1.Text == "V")
                    t_Amp1 = 1;
                else if (satuan_Amp1.Text == "mV")
                    t_Amp1 = 0.001;
                else if (satuan_Amp1.Text == "uV")
                    t_Amp1 = 0.000001;
                else if (satuan_Amp1.Text == "nV")
                    t_Amp1 = 0.000000001;
                else if (satuan_Amp1.Text == "pV")
                    t_Amp1 = 0.000000000001;

                if (Amp2_scale.Text == "GV")
                    t_Amp2 = 1000000000;
                else if (Amp2_scale.Text == "MV")
                    t_Amp2 = 1000000;
                else if (Amp2_scale.Text == "kV")
                    t_Amp2 = 1000;
                else if (Amp2_scale.Text == "V")
                    t_Amp2 = 1;
                else if (Amp2_scale.Text == "mV")
                    t_Amp2 = 0.001;
                else if (Amp2_scale.Text == "uV")
                    t_Amp2 = 0.000001;
                else if (Amp2_scale.Text == "nV")
                    t_Amp2 = 0.000000001;
                else if (Amp2_scale.Text == "pV")
                    t_Amp2 = 0.000000000001;

                if (sinyal3_tbox.Text == "GV")
                    t_Amp3 = 1000000000;
                else if (sinyal3_tbox.Text == "MV")
                    t_Amp3 = 1000000;
                else if (sinyal3_tbox.Text == "kV")
                    t_Amp3 = 1000;
                else if (sinyal3_tbox.Text == "V")
                    t_Amp3 = 1;
                else if (sinyal3_tbox.Text == "mV")
                    t_Amp3 = 0.001;
                else if (sinyal3_tbox.Text == "uV")
                    t_Amp3 = 0.000001;
                else if (sinyal3_tbox.Text == "nV")
                    t_Amp3 = 0.000000001;
                else if (sinyal3_tbox.Text == "pV")
                    t_Amp3 = 0.000000000001;
            }

            if (Freq1.Text == "kHz")
                k_freq1 = 1000;
            else if (Freq1.Text == "MHz")
                k_freq1 = 1000000;
            else if (Freq1.Text == "GHz")
                k_freq1 = 1000000000;
            else
                k_freq1 = 1;

            if (Freq2_scale.Text == "kHz")
                k_freq2 = 1000;
            else if (Freq2_scale.Text == "MHz")
                k_freq2 = 1000000;
            else if (Freq2_scale.Text == "GHz")
                k_freq2 = 1000000000;
            else
                k_freq2 = 1;

            if (Freq3_scale.Text == "kHz")
                k_freq3 = 1000;
            else if (Freq3_scale.Text == "MHz")
                k_freq3 = 1000000;
            else if (Freq3_scale.Text == "GHz")
                k_freq3 = 1000000000;
            else
                k_freq3 = 1;

            if (timer1.Enabled == true)
            {
                start_btn.Text = "Pause";
                stop_btn.Enabled = true;
            }
            else
            {
                amplitude1 = 0;
                amplitude2 = 0;
                amplitude3 = 0;
                frequency1 = 0;
                frequency2 = 0;
                frequency3 = 0;
                start_btn.Text = "Start";
            }
        }

        private void main_chart_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (dark_swit.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
                chart1.ChartAreas[0].BorderColor = Color.Black;
                chart1.BackColor = Color.White;
                chart1.ChartAreas[0].BackColor = Color.White;
                chart1.Legends[0].ForeColor = Color.Black;
                chart1.Legends[0].BackColor = Color.White;
                chart1.ForeColor = Color.Black;
                chart1.BorderlineColor = Color.Black;
                chart1.BorderSkin.BorderColor = Color.Black;
                chart1.ChartAreas[0].BorderColor = System.Drawing.Color.Black;
                chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.Black;
                chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.Black;
                chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            }
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK;
                chart1.ChartAreas[0].BorderColor = Color.White;
                chart1.BackColor = Color.Black;
                chart1.ChartAreas[0].BackColor = Color.Black;
                chart1.Legends[0].ForeColor = Color.White;
                chart1.Legends[0].BackColor = Color.Black;
                chart1.ForeColor = Color.White;
                chart1.BorderlineColor = Color.White;
                chart1.BorderSkin.BorderColor = Color.White;
                chart1.ChartAreas[0].BorderColor = System.Drawing.Color.White;
                chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.White;
                chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.White;
                chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            }
        }

        private void time_interval_box_TextChanged(object sender, EventArgs e)
        {
            if (time_interval_box.Text == "")
                time_interval = 100;
            else
                time_interval = double.Parse(time_interval_box.Text);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_scale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Amp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void satuan_Amp1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Freq1_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Freq1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series["Sinyal 2"].Points.Clear();
            chart1.Series["Sinyal 3"].Points.Clear();
            start_btn.Text = "Start";
            time = 0.00;
            timer1.Enabled = false;
            stop_btn.Enabled = false;
        }

        private void Amp2_tbox_TextChanged(object sender, EventArgs e)
        {
            /*amplitude2 = Convert.ToDouble(Amp2_tbox.Text);*/
        }

        private void Amp2_scale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Amp3_tbox_TextChanged(object sender, EventArgs e)
        {
            /*amplitude3 = Convert.ToDouble(Amp3_tbox.Text);*/
        }

        private void sinyal3_tbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Freq2_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void thick_textBox_TextChanged(object sender, EventArgs e)
        {
            if (thick_textBox.Text == null || thick_textBox.Text == "")
                thick = 1;
            else
                thick = int.Parse(thick_textBox.Text);
            chart1.Series[0].BorderWidth = thick;
            chart1.Series["Sinyal 2"].BorderWidth = thick;
            chart1.Series["Sinyal 3"].BorderWidth = thick;
        }

        private void time_inc_tbox_TextChanged(object sender, EventArgs e)
        {
            if(time_inc_tbox.Text == "")
                time_increase = 0.001;
            else
                time_increase = double.Parse(time_inc_tbox.Text);
        }

        private void Freq2_scale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Freq3_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Freq3_scale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
