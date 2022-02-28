namespace GUI_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.setting_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.time_interval_box = new MaterialSkin.Controls.MaterialTextBox();
            this.time_scale = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.sinyal1_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Freq1 = new MaterialSkin.Controls.MaterialComboBox();
            this.Amp1 = new MaterialSkin.Controls.MaterialTextBox();
            this.satuan_Amp1 = new MaterialSkin.Controls.MaterialComboBox();
            this.Freq1_tbox = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Sinyal2_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Freq2_tbox = new MaterialSkin.Controls.MaterialTextBox();
            this.Amp2_tbox = new MaterialSkin.Controls.MaterialTextBox();
            this.Amp2_scale = new MaterialSkin.Controls.MaterialComboBox();
            this.Freq2_scale = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.sinyal3_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.Freq3_tbox = new MaterialSkin.Controls.MaterialTextBox();
            this.Amp3_tbox = new MaterialSkin.Controls.MaterialTextBox();
            this.sinyal3_tbox = new MaterialSkin.Controls.MaterialComboBox();
            this.Freq3_scale = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.stop_btn = new MaterialSkin.Controls.MaterialButton();
            this.start_btn = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.Thick = new System.Windows.Forms.Label();
            this.thick_textBox = new System.Windows.Forms.TextBox();
            this.dark_swit = new MaterialSkin.Controls.MaterialSwitch();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.time_inc_lbl = new System.Windows.Forms.Label();
            this.time_inc_tbox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1372, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.setting_lbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel14, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.292528F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.903021F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.06F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.06F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.06F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 629);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // setting_lbl
            // 
            this.setting_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setting_lbl.AutoSize = true;
            this.setting_lbl.Depth = 0;
            this.setting_lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.setting_lbl.Location = new System.Drawing.Point(84, 4);
            this.setting_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.setting_lbl.Name = "setting_lbl";
            this.setting_lbl.Size = new System.Drawing.Size(51, 19);
            this.setting_lbl.TabIndex = 0;
            this.setting_lbl.Text = "Setting";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.05357F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.94643F));
            this.tableLayoutPanel4.Controls.Add(this.time_interval_box, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.time_scale, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(213, 48);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // time_interval_box
            // 
            this.time_interval_box.AnimateReadOnly = false;
            this.time_interval_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_interval_box.Depth = 0;
            this.time_interval_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_interval_box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.time_interval_box.Hint = "Time Interval";
            this.time_interval_box.LeadingIcon = null;
            this.time_interval_box.Location = new System.Drawing.Point(3, 4);
            this.time_interval_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_interval_box.MaxLength = 10;
            this.time_interval_box.MouseState = MaterialSkin.MouseState.OUT;
            this.time_interval_box.Multiline = false;
            this.time_interval_box.Name = "time_interval_box";
            this.time_interval_box.Size = new System.Drawing.Size(126, 50);
            this.time_interval_box.TabIndex = 1;
            this.time_interval_box.Text = "";
            this.time_interval_box.TrailingIcon = null;
            this.time_interval_box.TextChanged += new System.EventHandler(this.time_interval_box_TextChanged);
            // 
            // time_scale
            // 
            this.time_scale.AutoResize = false;
            this.time_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.time_scale.Depth = 0;
            this.time_scale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_scale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.time_scale.DropDownHeight = 174;
            this.time_scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_scale.DropDownWidth = 121;
            this.time_scale.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.time_scale.FormattingEnabled = true;
            this.time_scale.IntegralHeight = false;
            this.time_scale.ItemHeight = 43;
            this.time_scale.Items.AddRange(new object[] {
            "ms",
            "us",
            "ns",
            "ps"});
            this.time_scale.Location = new System.Drawing.Point(135, 4);
            this.time_scale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_scale.MaxDropDownItems = 4;
            this.time_scale.MouseState = MaterialSkin.MouseState.OUT;
            this.time_scale.Name = "time_scale";
            this.time_scale.Size = new System.Drawing.Size(75, 49);
            this.time_scale.StartIndex = 0;
            this.time_scale.TabIndex = 2;
            this.time_scale.SelectedIndexChanged += new System.EventHandler(this.time_scale_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.sinyal1_lbl, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 87);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.1875F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.8125F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(213, 162);
            this.tableLayoutPanel6.TabIndex = 5;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // sinyal1_lbl
            // 
            this.sinyal1_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinyal1_lbl.AutoSize = true;
            this.sinyal1_lbl.Depth = 0;
            this.sinyal1_lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sinyal1_lbl.Location = new System.Drawing.Point(77, 4);
            this.sinyal1_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.sinyal1_lbl.Name = "sinyal1_lbl";
            this.sinyal1_lbl.Size = new System.Drawing.Size(58, 19);
            this.sinyal1_lbl.TabIndex = 0;
            this.sinyal1_lbl.Text = "Sinyal 1";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.67281F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.32719F));
            this.tableLayoutPanel7.Controls.Add(this.Freq1, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.Amp1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.satuan_Amp1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.Freq1_tbox, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.74419F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.25581F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(207, 127);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // Freq1
            // 
            this.Freq1.AutoResize = false;
            this.Freq1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Freq1.Depth = 0;
            this.Freq1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freq1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Freq1.DropDownHeight = 174;
            this.Freq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Freq1.DropDownWidth = 121;
            this.Freq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Freq1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Freq1.FormattingEnabled = true;
            this.Freq1.IntegralHeight = false;
            this.Freq1.ItemHeight = 43;
            this.Freq1.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz",
            "GHz"});
            this.Freq1.Location = new System.Drawing.Point(132, 69);
            this.Freq1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Freq1.MaxDropDownItems = 4;
            this.Freq1.MouseState = MaterialSkin.MouseState.OUT;
            this.Freq1.Name = "Freq1";
            this.Freq1.Size = new System.Drawing.Size(72, 49);
            this.Freq1.StartIndex = 0;
            this.Freq1.TabIndex = 3;
            this.Freq1.SelectedIndexChanged += new System.EventHandler(this.Freq1_SelectedIndexChanged);
            // 
            // Amp1
            // 
            this.Amp1.AnimateReadOnly = false;
            this.Amp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amp1.Depth = 0;
            this.Amp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amp1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Amp1.Hint = "Amplitudo";
            this.Amp1.LeadingIcon = null;
            this.Amp1.Location = new System.Drawing.Point(3, 4);
            this.Amp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amp1.MaxLength = 50;
            this.Amp1.MouseState = MaterialSkin.MouseState.OUT;
            this.Amp1.Multiline = false;
            this.Amp1.Name = "Amp1";
            this.Amp1.Size = new System.Drawing.Size(123, 50);
            this.Amp1.TabIndex = 0;
            this.Amp1.Text = "";
            this.Amp1.TrailingIcon = null;
            this.Amp1.TextChanged += new System.EventHandler(this.Amp1_TextChanged);
            // 
            // satuan_Amp1
            // 
            this.satuan_Amp1.AutoResize = false;
            this.satuan_Amp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.satuan_Amp1.Depth = 0;
            this.satuan_Amp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satuan_Amp1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.satuan_Amp1.DropDownHeight = 174;
            this.satuan_Amp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.satuan_Amp1.DropDownWidth = 121;
            this.satuan_Amp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.satuan_Amp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.satuan_Amp1.FormattingEnabled = true;
            this.satuan_Amp1.IntegralHeight = false;
            this.satuan_Amp1.ItemHeight = 43;
            this.satuan_Amp1.Items.AddRange(new object[] {
            "GV",
            "MV",
            "kV",
            "V",
            "mV",
            "uV",
            "nV",
            "pV"});
            this.satuan_Amp1.Location = new System.Drawing.Point(132, 4);
            this.satuan_Amp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satuan_Amp1.MaxDropDownItems = 4;
            this.satuan_Amp1.MouseState = MaterialSkin.MouseState.OUT;
            this.satuan_Amp1.Name = "satuan_Amp1";
            this.satuan_Amp1.Size = new System.Drawing.Size(72, 49);
            this.satuan_Amp1.StartIndex = 3;
            this.satuan_Amp1.TabIndex = 1;
            this.satuan_Amp1.SelectedIndexChanged += new System.EventHandler(this.satuan_Amp1_SelectedIndexChanged);
            // 
            // Freq1_tbox
            // 
            this.Freq1_tbox.AnimateReadOnly = false;
            this.Freq1_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Freq1_tbox.Depth = 0;
            this.Freq1_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freq1_tbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Freq1_tbox.Hint = "Frequency";
            this.Freq1_tbox.LeadingIcon = null;
            this.Freq1_tbox.Location = new System.Drawing.Point(3, 69);
            this.Freq1_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Freq1_tbox.MaxLength = 50;
            this.Freq1_tbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Freq1_tbox.Multiline = false;
            this.Freq1_tbox.Name = "Freq1_tbox";
            this.Freq1_tbox.Size = new System.Drawing.Size(123, 50);
            this.Freq1_tbox.TabIndex = 2;
            this.Freq1_tbox.Text = "";
            this.Freq1_tbox.TrailingIcon = null;
            this.Freq1_tbox.TextChanged += new System.EventHandler(this.Freq1_tbox_TextChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.Sinyal2_lbl, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 257);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.4359F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.5641F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(213, 162);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // Sinyal2_lbl
            // 
            this.Sinyal2_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sinyal2_lbl.AutoSize = true;
            this.Sinyal2_lbl.Depth = 0;
            this.Sinyal2_lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Sinyal2_lbl.Location = new System.Drawing.Point(77, 8);
            this.Sinyal2_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sinyal2_lbl.Name = "Sinyal2_lbl";
            this.Sinyal2_lbl.Size = new System.Drawing.Size(58, 19);
            this.Sinyal2_lbl.TabIndex = 1;
            this.Sinyal2_lbl.Text = "Sinyal 2";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.13364F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.86636F));
            this.tableLayoutPanel9.Controls.Add(this.Freq2_tbox, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.Amp2_tbox, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.Amp2_scale, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.Freq2_scale, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(207, 118);
            this.tableLayoutPanel9.TabIndex = 2;
            this.tableLayoutPanel9.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel9_Paint);
            // 
            // Freq2_tbox
            // 
            this.Freq2_tbox.AnimateReadOnly = false;
            this.Freq2_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Freq2_tbox.Depth = 0;
            this.Freq2_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freq2_tbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Freq2_tbox.Hint = "Frequency";
            this.Freq2_tbox.LeadingIcon = null;
            this.Freq2_tbox.Location = new System.Drawing.Point(3, 63);
            this.Freq2_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Freq2_tbox.MaxLength = 50;
            this.Freq2_tbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Freq2_tbox.Multiline = false;
            this.Freq2_tbox.Name = "Freq2_tbox";
            this.Freq2_tbox.Size = new System.Drawing.Size(124, 50);
            this.Freq2_tbox.TabIndex = 3;
            this.Freq2_tbox.Text = "";
            this.Freq2_tbox.TrailingIcon = null;
            this.Freq2_tbox.TextChanged += new System.EventHandler(this.Freq2_tbox_TextChanged);
            // 
            // Amp2_tbox
            // 
            this.Amp2_tbox.AnimateReadOnly = false;
            this.Amp2_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amp2_tbox.Depth = 0;
            this.Amp2_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amp2_tbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Amp2_tbox.Hint = "Amplitudo";
            this.Amp2_tbox.LeadingIcon = null;
            this.Amp2_tbox.Location = new System.Drawing.Point(3, 4);
            this.Amp2_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amp2_tbox.MaxLength = 50;
            this.Amp2_tbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Amp2_tbox.Multiline = false;
            this.Amp2_tbox.Name = "Amp2_tbox";
            this.Amp2_tbox.Size = new System.Drawing.Size(124, 50);
            this.Amp2_tbox.TabIndex = 1;
            this.Amp2_tbox.Text = "";
            this.Amp2_tbox.TrailingIcon = null;
            this.Amp2_tbox.TextChanged += new System.EventHandler(this.Amp2_tbox_TextChanged);
            // 
            // Amp2_scale
            // 
            this.Amp2_scale.AutoResize = false;
            this.Amp2_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Amp2_scale.Depth = 0;
            this.Amp2_scale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amp2_scale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Amp2_scale.DropDownHeight = 174;
            this.Amp2_scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Amp2_scale.DropDownWidth = 121;
            this.Amp2_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Amp2_scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Amp2_scale.FormattingEnabled = true;
            this.Amp2_scale.IntegralHeight = false;
            this.Amp2_scale.ItemHeight = 43;
            this.Amp2_scale.Items.AddRange(new object[] {
            "GV",
            "MV",
            "kV",
            "V",
            "mV",
            "uV",
            "nV",
            "pV"});
            this.Amp2_scale.Location = new System.Drawing.Point(133, 4);
            this.Amp2_scale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amp2_scale.MaxDropDownItems = 4;
            this.Amp2_scale.MouseState = MaterialSkin.MouseState.OUT;
            this.Amp2_scale.Name = "Amp2_scale";
            this.Amp2_scale.Size = new System.Drawing.Size(71, 49);
            this.Amp2_scale.StartIndex = 3;
            this.Amp2_scale.TabIndex = 2;
            this.Amp2_scale.SelectedIndexChanged += new System.EventHandler(this.Amp2_scale_SelectedIndexChanged);
            // 
            // Freq2_scale
            // 
            this.Freq2_scale.AutoResize = false;
            this.Freq2_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Freq2_scale.Depth = 0;
            this.Freq2_scale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freq2_scale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Freq2_scale.DropDownHeight = 174;
            this.Freq2_scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Freq2_scale.DropDownWidth = 121;
            this.Freq2_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Freq2_scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Freq2_scale.FormattingEnabled = true;
            this.Freq2_scale.IntegralHeight = false;
            this.Freq2_scale.ItemHeight = 43;
            this.Freq2_scale.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz",
            "GHz"});
            this.Freq2_scale.Location = new System.Drawing.Point(133, 63);
            this.Freq2_scale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Freq2_scale.MaxDropDownItems = 4;
            this.Freq2_scale.MouseState = MaterialSkin.MouseState.OUT;
            this.Freq2_scale.Name = "Freq2_scale";
            this.Freq2_scale.Size = new System.Drawing.Size(71, 49);
            this.Freq2_scale.StartIndex = 0;
            this.Freq2_scale.TabIndex = 4;
            this.Freq2_scale.SelectedIndexChanged += new System.EventHandler(this.Freq2_scale_SelectedIndexChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.sinyal3_lbl, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 427);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.07407F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.92593F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(213, 162);
            this.tableLayoutPanel10.TabIndex = 7;
            // 
            // sinyal3_lbl
            // 
            this.sinyal3_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinyal3_lbl.AutoSize = true;
            this.sinyal3_lbl.Depth = 0;
            this.sinyal3_lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sinyal3_lbl.Location = new System.Drawing.Point(77, 9);
            this.sinyal3_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.sinyal3_lbl.Name = "sinyal3_lbl";
            this.sinyal3_lbl.Size = new System.Drawing.Size(58, 19);
            this.sinyal3_lbl.TabIndex = 2;
            this.sinyal3_lbl.Text = "Sinyal 3";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.13364F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.86636F));
            this.tableLayoutPanel11.Controls.Add(this.Freq3_tbox, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.Amp3_tbox, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.sinyal3_tbox, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.Freq3_scale, 1, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(207, 116);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // Freq3_tbox
            // 
            this.Freq3_tbox.AnimateReadOnly = false;
            this.Freq3_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Freq3_tbox.Depth = 0;
            this.Freq3_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freq3_tbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Freq3_tbox.Hint = "Frequency";
            this.Freq3_tbox.LeadingIcon = null;
            this.Freq3_tbox.Location = new System.Drawing.Point(3, 62);
            this.Freq3_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Freq3_tbox.MaxLength = 50;
            this.Freq3_tbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Freq3_tbox.Multiline = false;
            this.Freq3_tbox.Name = "Freq3_tbox";
            this.Freq3_tbox.Size = new System.Drawing.Size(124, 50);
            this.Freq3_tbox.TabIndex = 5;
            this.Freq3_tbox.Text = "";
            this.Freq3_tbox.TrailingIcon = null;
            this.Freq3_tbox.TextChanged += new System.EventHandler(this.Freq3_tbox_TextChanged);
            // 
            // Amp3_tbox
            // 
            this.Amp3_tbox.AnimateReadOnly = false;
            this.Amp3_tbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amp3_tbox.Depth = 0;
            this.Amp3_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amp3_tbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Amp3_tbox.Hint = "Amplitudo";
            this.Amp3_tbox.LeadingIcon = null;
            this.Amp3_tbox.Location = new System.Drawing.Point(3, 4);
            this.Amp3_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Amp3_tbox.MaxLength = 50;
            this.Amp3_tbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Amp3_tbox.Multiline = false;
            this.Amp3_tbox.Name = "Amp3_tbox";
            this.Amp3_tbox.Size = new System.Drawing.Size(124, 50);
            this.Amp3_tbox.TabIndex = 2;
            this.Amp3_tbox.Text = "";
            this.Amp3_tbox.TrailingIcon = null;
            this.Amp3_tbox.TextChanged += new System.EventHandler(this.Amp3_tbox_TextChanged);
            // 
            // sinyal3_tbox
            // 
            this.sinyal3_tbox.AutoResize = false;
            this.sinyal3_tbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sinyal3_tbox.Depth = 0;
            this.sinyal3_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinyal3_tbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sinyal3_tbox.DropDownHeight = 174;
            this.sinyal3_tbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sinyal3_tbox.DropDownWidth = 121;
            this.sinyal3_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sinyal3_tbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sinyal3_tbox.FormattingEnabled = true;
            this.sinyal3_tbox.IntegralHeight = false;
            this.sinyal3_tbox.ItemHeight = 43;
            this.sinyal3_tbox.Items.AddRange(new object[] {
            "GV",
            "MV",
            "kV",
            "V",
            "mV",
            "uV",
            "nV",
            "pV"});
            this.sinyal3_tbox.Location = new System.Drawing.Point(133, 4);
            this.sinyal3_tbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sinyal3_tbox.MaxDropDownItems = 4;
            this.sinyal3_tbox.MouseState = MaterialSkin.MouseState.OUT;
            this.sinyal3_tbox.Name = "sinyal3_tbox";
            this.sinyal3_tbox.Size = new System.Drawing.Size(71, 49);
            this.sinyal3_tbox.StartIndex = 3;
            this.sinyal3_tbox.TabIndex = 3;
            this.sinyal3_tbox.SelectedIndexChanged += new System.EventHandler(this.sinyal3_tbox_SelectedIndexChanged);
            // 
            // Freq3_scale
            // 
            this.Freq3_scale.AutoResize = false;
            this.Freq3_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Freq3_scale.Depth = 0;
            this.Freq3_scale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Freq3_scale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Freq3_scale.DropDownHeight = 174;
            this.Freq3_scale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Freq3_scale.DropDownWidth = 121;
            this.Freq3_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Freq3_scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Freq3_scale.FormattingEnabled = true;
            this.Freq3_scale.IntegralHeight = false;
            this.Freq3_scale.ItemHeight = 43;
            this.Freq3_scale.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz",
            "GHz"});
            this.Freq3_scale.Location = new System.Drawing.Point(133, 62);
            this.Freq3_scale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Freq3_scale.MaxDropDownItems = 4;
            this.Freq3_scale.MouseState = MaterialSkin.MouseState.OUT;
            this.Freq3_scale.Name = "Freq3_scale";
            this.Freq3_scale.Size = new System.Drawing.Size(71, 49);
            this.Freq3_scale.StartIndex = 0;
            this.Freq3_scale.TabIndex = 4;
            this.Freq3_scale.SelectedIndexChanged += new System.EventHandler(this.Freq3_scale_SelectedIndexChanged);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Controls.Add(this.stop_btn, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.start_btn, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 596);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(200, 30);
            this.tableLayoutPanel14.TabIndex = 8;
            // 
            // stop_btn
            // 
            this.stop_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stop_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stop_btn.Depth = 0;
            this.stop_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop_btn.Enabled = false;
            this.stop_btn.HighEmphasis = true;
            this.stop_btn.Icon = null;
            this.stop_btn.Location = new System.Drawing.Point(104, 6);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stop_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.stop_btn.Size = new System.Drawing.Size(92, 18);
            this.stop_btn.TabIndex = 4;
            this.stop_btn.Text = "Stop";
            this.stop_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stop_btn.UseAccentColor = false;
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.start_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.start_btn.Depth = 0;
            this.start_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_btn.HighEmphasis = true;
            this.start_btn.Icon = null;
            this.start_btn.Location = new System.Drawing.Point(4, 6);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.start_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.start_btn.Name = "start_btn";
            this.start_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.start_btn.Size = new System.Drawing.Size(92, 18);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "Start";
            this.start_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.start_btn.UseAccentColor = false;
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(228, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1141, 629);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dark_swit, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel13, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 594);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1135, 31);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel12.Controls.Add(this.Thick, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.thick_textBox, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(114, 23);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // Thick
            // 
            this.Thick.AutoSize = true;
            this.Thick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Thick.Location = new System.Drawing.Point(3, 0);
            this.Thick.Name = "Thick";
            this.Thick.Size = new System.Drawing.Size(85, 23);
            this.Thick.TabIndex = 0;
            this.Thick.Text = "Thickness";
            // 
            // thick_textBox
            // 
            this.thick_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thick_textBox.Location = new System.Drawing.Point(91, 0);
            this.thick_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.thick_textBox.Name = "thick_textBox";
            this.thick_textBox.Size = new System.Drawing.Size(23, 20);
            this.thick_textBox.TabIndex = 1;
            this.thick_textBox.TextChanged += new System.EventHandler(this.thick_textBox_TextChanged);
            // 
            // dark_swit
            // 
            this.dark_swit.AutoSize = true;
            this.dark_swit.BackColor = System.Drawing.Color.Transparent;
            this.dark_swit.Depth = 0;
            this.dark_swit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dark_swit.Location = new System.Drawing.Point(985, 0);
            this.dark_swit.Margin = new System.Windows.Forms.Padding(0);
            this.dark_swit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dark_swit.MouseState = MaterialSkin.MouseState.HOVER;
            this.dark_swit.Name = "dark_swit";
            this.dark_swit.Ripple = true;
            this.dark_swit.Size = new System.Drawing.Size(150, 31);
            this.dark_swit.TabIndex = 0;
            this.dark_swit.Text = "Light Mode";
            this.dark_swit.UseVisualStyleBackColor = false;
            this.dark_swit.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel13.Controls.Add(this.time_inc_lbl, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.time_inc_tbox, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(838, 4);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(144, 23);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // time_inc_lbl
            // 
            this.time_inc_lbl.AutoSize = true;
            this.time_inc_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_inc_lbl.Location = new System.Drawing.Point(3, 0);
            this.time_inc_lbl.Name = "time_inc_lbl";
            this.time_inc_lbl.Size = new System.Drawing.Size(71, 23);
            this.time_inc_lbl.TabIndex = 0;
            this.time_inc_lbl.Text = "Time Inc";
            // 
            // time_inc_tbox
            // 
            this.time_inc_tbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_inc_tbox.Location = new System.Drawing.Point(77, 0);
            this.time_inc_tbox.Margin = new System.Windows.Forms.Padding(0);
            this.time_inc_tbox.Name = "time_inc_tbox";
            this.time_inc_tbox.Size = new System.Drawing.Size(40, 20);
            this.time_inc_tbox.TabIndex = 1;
            this.time_inc_tbox.TextChanged += new System.EventHandler(this.time_inc_tbox_TextChanged);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Time (s)";
            chartArea1.BackColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BorderWidth = 2;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 30F;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 2;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1141, 590);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 704);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 63, 3, 4);
            this.Text = "Signal Plotter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel setting_lbl;
        private MaterialSkin.Controls.MaterialButton start_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialLabel sinyal1_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialComboBox Freq1;
        private MaterialSkin.Controls.MaterialTextBox Amp1;
        private MaterialSkin.Controls.MaterialComboBox satuan_Amp1;
        private MaterialSkin.Controls.MaterialTextBox Freq1_tbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialLabel Sinyal2_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialTextBox Freq2_tbox;
        private MaterialSkin.Controls.MaterialTextBox Amp2_tbox;
        private MaterialSkin.Controls.MaterialComboBox Amp2_scale;
        private MaterialSkin.Controls.MaterialComboBox Freq2_scale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private MaterialSkin.Controls.MaterialLabel sinyal3_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private MaterialSkin.Controls.MaterialTextBox Freq3_tbox;
        private MaterialSkin.Controls.MaterialTextBox Amp3_tbox;
        private MaterialSkin.Controls.MaterialComboBox sinyal3_tbox;
        private MaterialSkin.Controls.MaterialComboBox Freq3_scale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialTextBox time_interval_box;
        private MaterialSkin.Controls.MaterialComboBox time_scale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialSwitch dark_swit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label Thick;
        private System.Windows.Forms.TextBox thick_textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label time_inc_lbl;
        private System.Windows.Forms.TextBox time_inc_tbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private MaterialSkin.Controls.MaterialButton stop_btn;
    }
}

