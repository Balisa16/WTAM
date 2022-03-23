using MaterialSkin; //Menambahkan framework material skin agar tampilan lebih elegan.
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
            InitializeComponent(); //Menginilisasi semua komponen yang dibutuhkan
            var materialSkinManager = MaterialSkinManager.Instance; //Memuat instansi dari Material Skin Manager kedalam sebuah variable
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //Membuat skin / aplikasi pertama kali dijalankan dalam mode dark
            //Inilisasi warna yang digunakan (Saya menggunakan kombinasi Bluegray Color)
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            chart1.ChartAreas[0].BorderColor = System.Drawing.Color.White; //Mengatur garis tepi area grafik berwarna putih.
            chart1.ChartAreas[0].BackColor = Color.Black; //Mengatur Background area grafik menjadi hitam
            chart1.ChartAreas[0].AxisX.Title = "Time (ms)"; // Mengatur label pada axis horizontal dengan nama "Time (ms)"
            chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.White; // Mengatur warna garis horizontal dengan warna putih
            chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.White; // Mengatur warna garis vertikal dengan warna putih
            chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            //Mengatur garis dash dengan garis titik titik.


            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00"; //Mengatur resolusi axis x menjadi dua angka dibelakang koma

            chart1.BackColor = Color.Black; //Mengatur background area chart dengan warna hitam
            chart1.Legends[0].BackColor = Color.Black; //Mengatur background area legenda dengan warna hitam
            chart1.Legends[0].ForeColor = Color.White; //Mengatur warna tulisan pada area legenda menjadi putih
            chart1.BorderlineColor = Color.White; //Mengatur warna garis tepi pada rangkaian menjadi putih
            chart1.BorderSkin.BorderColor = Color.White; //Garis tepi untuk border color menjadi warna putih

            thick = 1; //Memberikan inilisasi default ketebalan garis pada grafik menjadi 1;
            time_increase = 0.001; //Menginilisasi peningkatan waktu yang akan digunakan.
            Axis_y_title = "Voltage (V)"; //Mengatur nama label pada garis Vertikal

            chart1.Series[0].Name = "Sinyal 1"; //Mengatur Nama garis ke 0 menjadi Sinyal 1
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Mengatur tipe Sinyal pertama menjadi garis
            chart1.Series[0].BorderWidth = thick; //Mengatur ketebalan dari Sinyal 1 sama dengan variabel thick
            chart1.Series[0].Color = Color.Red; //Mengatur warna garis Sinyal 1 menjadi Warna Merah
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom; //Mengatur penempatan legenda pada daerah bawah.

            chart1.Series.Add("Sinyal 2"); //Menambahkan sebuah series baru dengan nama Sinyal 2
            chart1.Series["Sinyal 2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Mengatur tipe Sinyal 2 menjadi garis
            chart1.Series["Sinyal 2"].BorderWidth = thick; //Mengatur ketebalan dari Sinyal 2 sama dengan variabel thick
            chart1.Series["Sinyal 2"].Color = Color.Green; //Mengatur warna garis Sinyal 2 menjadi Warna Hijau

            chart1.Series.Add("Sinyal 3"); //Menambahkan sebuah series baru dengan nama Sinyal 3
            chart1.Series["Sinyal 3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Mengatur tipe Sinyal 3 menjadi garis
            chart1.Series["Sinyal 3"].BorderWidth = thick; //Mengatur ketebalan dari Sinyal 3 sama dengan variabel thick
            chart1.Series["Sinyal 3"].Color = Color.Blue; //Mengatur warna garis Sinyal 3 menjadi Warna Biru
        }

        //Menginilisasi variabel variabel yang akan digunakan
        private double time = 0.0;
        private double amplitude1 = 0, amplitude2 = 0, amplitude3 = 0;
        private double frequency1 = 0, frequency2 = 0, frequency3 = 0;
        private int thick;
        private double time_interval, time_increase, t_Amp1, t_Amp2, t_Amp3, time_interval2, time2;
        private string time_sc, time_sc2, Axis_y_title;
        private int k_freq1, k_freq2, k_freq3;
        private bool Stop = false;

        MaterialSkinManager TManager = MaterialSkinManager.Instance; //Menambahkan sebuah instansi dari Material Skin Manager

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Jika nilai pada textbox Amp1 kosong maka variabel amplitude1 akan diinilisasi menjadi 0 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel amplitude1
            if (Amp1.Text == "")
                amplitude1 = 0;
            else
                amplitude1 = double.Parse(Amp1.Text) * t_Amp1;

            //Jika nilai pada textbox Amp3_tbox kosong maka variabel amplitude2 akan diinilisasi menjadi 0 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel amplitude2
            if (Amp2_tbox.Text == "")
                amplitude2 = 0;
            else
                amplitude2 = double.Parse(Amp2_tbox.Text) * t_Amp2;

            //Jika nilai pada textbox Amp3_tbox kosong maka variabel amplitude2 akan diinilisasi menjadi 0 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel amplitude3
            if (Amp3_tbox.Text == "")
                amplitude3 = 0;
            else
                amplitude3 = double.Parse(Amp3_tbox.Text) * t_Amp3;

            //Jika nilai pada textbox Freq1_tbox kosong maka variabel frequency1 akan diinilisasi menjadi 0 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel frequency1
            if (Freq1_tbox.Text == "")
                frequency1 = 0;
            else
                frequency1 = double.Parse(Freq1_tbox.Text) * k_freq1;
            
            //Jika nilai pada textbox Freq2_tbox kosong maka variabel frequency2 akan diinilisasi menjadi 0 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel frequency2
            if (Freq2_tbox.Text == "")
                frequency2 = 0;
            else
                frequency2 = double.Parse(Freq2_tbox.Text) * k_freq2;

            //Jika nilai pada textbox Freq3_tbox kosong maka variabel frequency3 akan diinilisasi menjadi 0 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel frequency3
            if (Freq3_tbox.Text == "")
                frequency3 = 0;
            else
                frequency3 = double.Parse(Freq3_tbox.Text) * k_freq3;
            
            //Mengkalkulasikan nilai dari tiap masukan pada textbox 
            double y1 = amplitude1 * Math.Sin(2 * Math.PI * frequency1 * time);
            double y2 = amplitude2 * Math.Sin(2 * Math.PI * frequency2 * time);
            double y3 = amplitude3 * Math.Sin(2 * Math.PI * frequency3 * time);

            //Jika nilai pada textbox time_interval_box kosong maka variabel time_interval akan diinilisasi menjadi 100 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel time_interval
            if (time_interval_box.Text == "")
                time_interval = 100;
            else
                time_interval = double.Parse(time_interval_box.Text);
            
            // mengecek apakah mode Double Graph dalam keadaan tru atau false
            if (materialSwitch1.Checked)
            {
                //Jika nilai pada textbox materialTextBox1 kosong maka variabel time_interval2 akan diinilisasi menjadi 100 saja
                //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
                //double dan dimasukkan kedalam variabel time_interval2
                if (materialTextBox1.Text == "")
                    time_interval2 = 100;
                else
                    time_interval2 = double.Parse(materialTextBox1.Text);

                time_sc2 = materialComboBox1.Text; //Mengambil skala pada MaterialComboBox1

                // melakukan konversi sesuai satuan yang dimaksudkan.
                if (time_sc2 == "ms")
                    chart1.ChartAreas["Chart2"].AxisX.Title = "Time (ms)";
                else if (time_sc2 == "us")
                    chart1.ChartAreas["Chart2"].AxisX.Title = "Time (us)";
                else if (time_sc2 == "ns")
                    chart1.ChartAreas["Chart2"].AxisX.Title = "Time (ns)";
                else if (time_sc2 == "ps")
                    chart1.ChartAreas["Chart2"].AxisX.Title = "Time (ps)";
                else
                    chart1.ChartAreas["Chart2"].AxisX.Title = "Time (s)";

                // Memberikan judul label vertikal pada Chart2
                chart1.ChartAreas["Chart2"].AxisY.Title = Axis_y_title;

                // menggabarkan perhitungan pada Sinyal21, Sinyal22, Sinyal23
                chart1.Series["Sinyal 21"].Points.AddXY(time, y1);
                chart1.Series["Sinyal 22"].Points.AddXY(time, y2);
                chart1.Series["Sinyal 23"].Points.AddXY(time, y3);
            }

            // mengambil skala waktu pada time intuk grafik pertama. 
            time_sc = time_scale.Text;

            // melakukan konversi sesuai satuan yang dimaksudkan.
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
            
            // menggabarkan perhitungan pada Sinyal1, Sinyal2, Sinyal3
            chart1.Series[0].Points.AddXY(time, y1);
            chart1.Series["Sinyal 2"].Points.AddXY(time, y2);
            chart1.Series["Sinyal 3"].Points.AddXY(time, y3);
            
            // Menambahkan iterasi pada time dan time1 sesuai dengan time increase yang dimasukkan
            time += time_increase;
            time2 += time_increase;

            // Mengatur timing minimum dan timing maksimum pada Chart1 
            if (chart1.Series[0].Points.Count > time_interval)
            {
                double timing = time - (time_increase * time_interval);
                chart1.ChartAreas[0].AxisX.Minimum = timing;
                chart1.ChartAreas[0].AxisX.Maximum = time;
            }

            // Mengatur timing minimum dan timing maksimum pada Chart1 hanya jika double graph diaktifkan oleh user
            if (materialSwitch1.Checked && chart1.Series["Sinyal 21"].Points.Count > time_interval2)
            {
                double timing2 = time2 - (time_increase * time_interval2);
                chart1.ChartAreas["Chart2"].AxisX.Minimum = timing2;
                chart1.ChartAreas["Chart2"].AxisX.Maximum = time2;
            }
        }


        private void start_btn_Click(object sender, EventArgs e)
        {
            // Jika tombol start_btn ditekan maka timer akan dinegasikan sehingga menjadi kebalikan dari kondisi sebelumnya
            timer1.Enabled = !(timer1.Enabled);

            // melakukan konversi sesuai satuan yang dimaksudkan.
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

            // Jika timer berada dalam keadaan true maka :
            if (timer1.Enabled == true)
            {
                start_btn.Text = "Pause"; //Teks pada start_btn akan diubah menjadi Pause
                stop_btn.Enabled = true; //Tombol start akan di enable.
            }
            // Jika timer berada dalam keadaan false maka :
            else
            {
                //Semua variabel dijadikan 0
                amplitude1 = 0;
                amplitude2 = 0;
                amplitude3 = 0;
                frequency1 = 0;
                frequency2 = 0;
                frequency3 = 0;

                //Teks pada start_btn akan diubah menjadi kata Start
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
            // Jika switch Light Switch diaktifkan
            if (dark_swit.Checked)
            {
                TManager.Theme = MaterialSkinManager.Themes.LIGHT; //Skin dari aplikasi akan diubah ke mode Light
                chart1.ChartAreas[0].BorderColor = Color.Black;  //Garis tepi dari Chart 1 akan diubah ke warna hitam
                chart1.BackColor = Color.White; // Background Color dari area chart1 akan diubah menjadi white
                chart1.ChartAreas[0].BackColor = Color.White; // Untuk background chart area 1 akan diubah menjadi warna putih
                chart1.Legends[0].ForeColor = Color.Black; //Tulisan pada Legenda akan diubah menjadi warna hitam
                chart1.Legends[0].BackColor = Color.White; //Background color pada Legenda akan diubah menjadi warna putih
                chart1.ForeColor = Color.Black; // Semua tulisan pada chart1 akan diubah menjadi warna hitam
                chart1.BorderlineColor = Color.Black; //Untuk garis tepi chart1 akan diberi warna hitam
                chart1.BorderSkin.BorderColor = Color.Black; //Garis tepi untuk kulit dari tepi grafik akan diubah memnjadi warna hitam
                chart1.ChartAreas[0].BorderColor = System.Drawing.Color.Black; //Pada chartarea 0 akan diubah menjadi warna hitam
                chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.Black; // Untuk warna garis horizontal chartarea 0 akan diberi warna hitam
                chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.Black; // Untuk warna garis vertical chartarea 0 akan diberi warna hitam
                chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                //Mengatur garis dash dengan garis titik titik.

                if (materialSwitch1.Checked)
                {
                    chart1.ChartAreas["Chart2"].BorderColor = Color.Black; //Garis tepi dari Chart2 akan diubah ke warna hitam
                    chart1.ChartAreas["Chart2"].BackColor = Color.White; //Background Color dari area Chart2 akan diubah menjadi white
                    chart1.ChartAreas["Chart2"].BorderColor = System.Drawing.Color.Black; //Pada chartarea Chart2 akan diubah menjadi warna hitam
                    chart1.ChartAreas["Chart2"].AxisX.LineColor = System.Drawing.Color.Black; // Untuk warna garis horizontal chartarea Chart2 akan diberi warna hitam
                    chart1.ChartAreas["Chart2"].AxisY.LineColor = System.Drawing.Color.Black; // Untuk warna garis vertical chartarea Chart2 akan diberi warna hitam
                    chart1.ChartAreas["Chart2"].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                    //Mengatur garis dash dengan garis titik titik.
                }
            }
            // Jika switch Light Switch tidak diaktifkan
            else
            {
                TManager.Theme = MaterialSkinManager.Themes.DARK; //Skin dari aplikasi akan diubah ke mode Dark
                chart1.ChartAreas[0].BorderColor = Color.White; //Garis tepi dari Chart 1 akan diubah ke warna putih
                chart1.BackColor = Color.Black; // Background Color dari area chart1 akan diubah menjadi hitam
                chart1.ChartAreas[0].BackColor = Color.Black; // Untuk background chart area 1 akan diubah menjadi warna hitam
                chart1.Legends[0].ForeColor = Color.White; //Tulisan pada Legenda akan diubah menjadi warna putih
                chart1.Legends[0].BackColor = Color.Black; //Background color pada Legenda akan diubah menjadi warna hitam
                chart1.ForeColor = Color.White; // Semua tulisan pada chart1 akan diubah menjadi warna putih
                chart1.BorderlineColor = Color.White; //Untuk garis tepi chart1 akan diberi warna putih
                chart1.BorderSkin.BorderColor = Color.White; //Garis tepi untuk kulit dari tepi grafik akan diubah memnjadi warna putih
                chart1.ChartAreas[0].BorderColor = System.Drawing.Color.White; //Pada chartarea 0 akan diubah menjadi warna putih
                chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.White; // Untuk warna garis horizontal chartarea 0 akan diberi warna putih
                chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.White; // Untuk warna garis vertical chartarea 0 akan diberi warna putih
                chart1.ChartAreas[0].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                //Mengatur garis dash dengan garis titik titik.

                if (materialSwitch1.Checked)
                {
                    chart1.ChartAreas["Chart2"].BorderColor = Color.White; //Garis tepi dari Chart2 akan diubah ke warna putih
                    chart1.ChartAreas["Chart2"].BackColor = Color.Black; //Background Color dari area Chart2 akan diubah menjadi hitam
                    chart1.ChartAreas["Chart2"].BorderColor = System.Drawing.Color.White; //Pada chartarea Chart2 akan diubah menjadi warna putih
                    chart1.ChartAreas["Chart2"].AxisX.LineColor = System.Drawing.Color.White; // Untuk warna garis horizontal chartarea Chart2 akan diberi warna putih
                    chart1.ChartAreas["Chart2"].AxisY.LineColor = System.Drawing.Color.White; // Untuk warna garis vertical chartarea Chart2 akan diberi warna putih
                    chart1.ChartAreas["Chart2"].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                    //Mengatur garis dash dengan garis titik titik.
                }
            }
        }

        private void time_interval_box_TextChanged(object sender, EventArgs e)
        {
            //Jika nilai pada textbox time_interval_box kosong maka variabel time_interval akan diinilisasi menjadi 100 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel time_interval
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
            // Jika tombol stop_btn ditekan maka :
            chart1.Series[0].Points.Clear(); //Series 0 akan dihapus
            chart1.Series["Sinyal 2"].Points.Clear(); //Series Sinyal 2 akan dihapus
            chart1.Series["Sinyal 3"].Points.Clear(); //Series Sinyal 3 akan dihapus

            //Jika mode double graph aktif
            if (materialSwitch1.Checked)
            {
                chart1.Series["Sinyal 21"].Points.Clear(); //Series Sinyal 21 akan dihapus
                chart1.Series["Sinyal 22"].Points.Clear(); //Series Sinyal 22 akan dihapus
                chart1.Series["Sinyal 23"].Points.Clear(); //Series Sinyal 23 akan dihapus
            }

            start_btn.Text = "Start"; //Mengubah teks pada tombol start_btn menjadi Start
            time = 0.00; //Mereset variabel time
            time2 = 0.00; //Mereset variabel time2
            Stop = true; //Mengubah variabel Stop menjadi true
            timer1.Enabled = false; //Mengubah keadaan timer menjadi disable
            stop_btn.Enabled = false; //Mengubah keadaan dirinya sendiri (stop_btn) menjadi disable
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            //Jika mode double graph diaktifkan
            if (materialSwitch1.Checked)
            {
                materialTextBox1.Enabled = true; //Mengaktifkan textbox materialTextBox1
                materialComboBox1.Enabled = true; //Mengaktifkan textbox materialComboBox1
                chart1.ChartAreas.Add("Chart2"); //Menambahkan sebuah grafik dengan nama Chart2
                chart1.ChartAreas["Chart2"].AxisX.Title = "Time (ms)"; //Mengatur judul axis horizontal dengan nama Time (ms)
                chart1.ChartAreas["Chart2"].AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
                //Mengatur garis dash dengan garis titik titik.
                chart1.ChartAreas["Chart2"].AxisX.LabelStyle.Format = "0.00"; //Mengatur resolusi axis x menjadi dua angka dibelakang koma

                // Mengecek apakah switch light mode dalam keadaan aktif
                if (dark_swit.Checked)
                {
                    chart1.ChartAreas["Chart2"].BorderColor = System.Drawing.Color.Black; //Mengatur warna garis tepi pada Chart2 menjadi warna hitam
                    chart1.ChartAreas["Chart2"].BackColor = Color.White;  //Mengatur warna background tepi pada Chart2 menjadi warna putih
                    chart1.ChartAreas["Chart2"].AxisX.LineColor = System.Drawing.Color.Black; //Mengatur warna garis sumbu horizontal pada Chart2 menjadi warna hitam
                    chart1.ChartAreas["Chart2"].AxisY.LineColor = System.Drawing.Color.Black; //Mengatur warna garis sumbu vertikal pada Chart2 menjadi warna hitam
                }
                else
                {
                    chart1.ChartAreas["Chart2"].BorderColor = System.Drawing.Color.White; //Mengatur warna garis tepi pada Chart2 menjadi warna putih
                    chart1.ChartAreas["Chart2"].BackColor = Color.Black; //Mengatur warna background tepi pada Chart2 menjadi warna hitam
                    chart1.ChartAreas["Chart2"].AxisX.LineColor = System.Drawing.Color.White; //Mengatur warna garis sumbu horizontal pada Chart2 menjadi warna putih
                    chart1.ChartAreas["Chart2"].AxisY.LineColor = System.Drawing.Color.White; //Mengatur warna garis sumbu vertikal pada Chart2 menjadi warna putih
                }

                //if(Stop == false)
                //{
                    chart1.Series.Add("Sinyal 21"); //Menambahkan series Sinyal 21
                    chart1.Series.Add("Sinyal 22"); //Menambahkan series Sinyal 22
                    chart1.Series.Add("Sinyal 23"); //Menambahkan series Sinyal 23

                    chart1.Series["Sinyal 21"].ChartArea = "Chart2"; //Mengatur peletakan Sinyal 21 pada Chart2
                    chart1.Series["Sinyal 21"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Mengatur  visualisasi Sinyal 21 menjadi bentuk garis
                    chart1.Series["Sinyal 21"].BorderWidth = thick;  //Mengatur ketebalan Sinyal 21 menjadi nilai yang sama dengan variabel thick
                    chart1.Series["Sinyal 21"].Color = Color.Red;  //Mengatur warna garis Sinyal 21 menjadi warna merah

                    chart1.Series["Sinyal 22"].ChartArea = "Chart2"; //Mengatur peletakan Sinyal 22 pada Chart2
                    chart1.Series["Sinyal 22"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;  //Mengatur  visualisasi Sinyal 22 menjadi bentuk garis
                    chart1.Series["Sinyal 22"].BorderWidth = thick; //Mengatur ketebalan Sinyal 22 menjadi nilai yang sama dengan variabel thick
                    chart1.Series["Sinyal 22"].Color = Color.Green; //Mengatur warna garis Sinyal 22 menjadi warna hijau

                    chart1.Series["Sinyal 23"].ChartArea = "Chart2"; //Mengatur peletakan Sinyal 23 pada Chart2
                    chart1.Series["Sinyal 23"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;  //Mengatur  visualisasi Sinyal 23 menjadi bentuk garis
                    chart1.Series["Sinyal 23"].BorderWidth = thick; //Mengatur ketebalan Sinyal 23 menjadi nilai yang sama dengan variabel thick
                    chart1.Series["Sinyal 23"].Color = Color.Violet;//Mengatur warna garis Sinyal 21 menjadi warna ungu
                //}
            }
            else
            {
                //chart1.ChartAreas.Remove("Chart2");
                materialTextBox1.Enabled = false; //menonaktifkan materialTextBox1
                materialComboBox1.Enabled = false; //menonaktifkan materialComboBox1
                chart1.Series.RemoveAt(chart1.Series.IndexOf("Sinyal 21")); //Menghapus series Sinyal 21
                chart1.Series.RemoveAt(chart1.Series.IndexOf("Sinyal 22")); //Menghapus series Sinyal 22
                chart1.Series.RemoveAt(chart1.Series.IndexOf("Sinyal 23")); //Menghapus series Sinyal 23
                chart1.ChartAreas.RemoveAt(chart1.ChartAreas.IndexOf("Chart2")); //Menghapus grafik Chart2
            }
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
            //Jika nilai pada textbox thick_textBox kosong maka variabel thick akan diinilisasi menjadi 1 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel thick
            if (thick_textBox.Text == null || thick_textBox.Text == "")
                thick = 1;
            else
                thick = int.Parse(thick_textBox.Text);

            chart1.Series[0].BorderWidth = thick; //Mengatur ulang ketebalan dari garis Sinyal1 sesuai dengan angka pada variabel thick
            chart1.Series["Sinyal 2"].BorderWidth = thick; //Mengatur ulang ketebalan dari garis Sinyal2 sesuai dengan angka pada variabel thick
            chart1.Series["Sinyal 3"].BorderWidth = thick; //Mengatur ulang ketebalan dari garis Sinyal3 sesuai dengan angka pada variabel thick
            if (materialSwitch1.Checked)
            {
                chart1.Series["Sinyal 21"].BorderWidth = thick; //Mengatur ulang ketebalan dari garis Sinyal21 sesuai dengan angka pada variabel thick
                chart1.Series["Sinyal 22"].BorderWidth = thick; //Mengatur ulang ketebalan dari garis Sinyal22 sesuai dengan angka pada variabel thick
                chart1.Series["Sinyal 23"].BorderWidth = thick; //Mengatur ulang ketebalan dari garis Sinyal23 sesuai dengan angka pada variabel thick
            }
        }

        private void time_inc_tbox_TextChanged(object sender, EventArgs e)
        {
            //Jika nilai pada textbox time_inc_tbox kosong maka variabel time_increase akan diinilisasi menjadi 0.001 saja
            //Tapi jika terdapat angka yang dimasukkan maka akan diconvert menjadi sebuah data bertipe
            //double dan dimasukkan kedalam variabel time_increase
            if (time_inc_tbox.Text == "")
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
