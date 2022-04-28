namespace Prak_6
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupSplitter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.suhubox = new MaterialSkin.Controls.MaterialTextBox();
            this.kelembapanbox = new MaterialSkin.Controls.MaterialTextBox();
            this.tekananbox = new MaterialSkin.Controls.MaterialTextBox();
            this.UVindexbox = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.stop = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Temp_Request = new MaterialSkin.Controls.MaterialButton();
            this.Kelembapan_Request = new MaterialSkin.Controls.MaterialButton();
            this.Pressure_Request = new MaterialSkin.Controls.MaterialButton();
            this.UV_Request = new MaterialSkin.Controls.MaterialButton();
            this.All_Request = new MaterialSkin.Controls.MaterialButton();
            this.groupReceived = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.listReceived = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sending_msg = new System.Windows.Forms.ListBox();
            this.groupSerialSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Baudrate = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.connectbtn = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.PortName = new MaterialSkin.Controls.MaterialComboBox();
            this.send_msgbox = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.delete_msg = new MaterialSkin.Controls.MaterialButton();
            this.send_msg = new MaterialSkin.Controls.MaterialButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RecordGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.fileCostumeName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.SlctFilePath = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupSplitter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupReceived.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupSerialSetting.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.RecordGroup.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.groupSplitter, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupReceived, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupSerialSetting, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupSplitter
            // 
            this.groupSplitter.Controls.Add(this.tableLayoutPanel2);
            this.groupSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSplitter.Location = new System.Drawing.Point(693, 3);
            this.groupSplitter.Name = "groupSplitter";
            this.groupSplitter.Size = new System.Drawing.Size(260, 410);
            this.groupSplitter.TabIndex = 0;
            this.groupSplitter.TabStop = false;
            this.groupSplitter.Text = "Splited Data";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.suhubox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.kelembapanbox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tekananbox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.UVindexbox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 391);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // suhubox
            // 
            this.suhubox.AnimateReadOnly = false;
            this.suhubox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suhubox.Depth = 0;
            this.suhubox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suhubox.Enabled = false;
            this.suhubox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.suhubox.Hint = "Suhu";
            this.suhubox.LeadingIcon = null;
            this.suhubox.Location = new System.Drawing.Point(3, 3);
            this.suhubox.MaxLength = 50;
            this.suhubox.MouseState = MaterialSkin.MouseState.OUT;
            this.suhubox.Multiline = false;
            this.suhubox.Name = "suhubox";
            this.suhubox.Size = new System.Drawing.Size(248, 50);
            this.suhubox.TabIndex = 0;
            this.suhubox.Text = "";
            this.suhubox.TrailingIcon = null;
            // 
            // kelembapanbox
            // 
            this.kelembapanbox.AnimateReadOnly = false;
            this.kelembapanbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kelembapanbox.Depth = 0;
            this.kelembapanbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kelembapanbox.Enabled = false;
            this.kelembapanbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kelembapanbox.Hint = "Kelembapan";
            this.kelembapanbox.LeadingIcon = null;
            this.kelembapanbox.Location = new System.Drawing.Point(3, 58);
            this.kelembapanbox.MaxLength = 50;
            this.kelembapanbox.MouseState = MaterialSkin.MouseState.OUT;
            this.kelembapanbox.Multiline = false;
            this.kelembapanbox.Name = "kelembapanbox";
            this.kelembapanbox.Size = new System.Drawing.Size(248, 50);
            this.kelembapanbox.TabIndex = 1;
            this.kelembapanbox.Text = "";
            this.kelembapanbox.TrailingIcon = null;
            // 
            // tekananbox
            // 
            this.tekananbox.AnimateReadOnly = false;
            this.tekananbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tekananbox.Depth = 0;
            this.tekananbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tekananbox.Enabled = false;
            this.tekananbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tekananbox.Hint = "Tekanan Udara";
            this.tekananbox.LeadingIcon = null;
            this.tekananbox.Location = new System.Drawing.Point(3, 113);
            this.tekananbox.MaxLength = 50;
            this.tekananbox.MouseState = MaterialSkin.MouseState.OUT;
            this.tekananbox.Multiline = false;
            this.tekananbox.Name = "tekananbox";
            this.tekananbox.Size = new System.Drawing.Size(248, 50);
            this.tekananbox.TabIndex = 2;
            this.tekananbox.Text = "";
            this.tekananbox.TrailingIcon = null;
            // 
            // UVindexbox
            // 
            this.UVindexbox.AnimateReadOnly = false;
            this.UVindexbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UVindexbox.Depth = 0;
            this.UVindexbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UVindexbox.Enabled = false;
            this.UVindexbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UVindexbox.Hint = "UV Index";
            this.UVindexbox.LeadingIcon = null;
            this.UVindexbox.Location = new System.Drawing.Point(3, 168);
            this.UVindexbox.MaxLength = 50;
            this.UVindexbox.MouseState = MaterialSkin.MouseState.OUT;
            this.UVindexbox.Multiline = false;
            this.UVindexbox.Name = "UVindexbox";
            this.UVindexbox.Size = new System.Drawing.Size(248, 50);
            this.UVindexbox.TabIndex = 3;
            this.UVindexbox.Text = "";
            this.UVindexbox.TrailingIcon = null;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.materialButton2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.stop, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(248, 34);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton2.Enabled = false;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(4, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(116, 22);
            this.materialButton2.TabIndex = 0;
            this.materialButton2.Text = "Clear";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // stop
            // 
            this.stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stop.Depth = 0;
            this.stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop.Enabled = false;
            this.stop.HighEmphasis = true;
            this.stop.Icon = null;
            this.stop.Location = new System.Drawing.Point(128, 6);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stop.MouseState = MaterialSkin.MouseState.HOVER;
            this.stop.Name = "stop";
            this.stop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.stop.Size = new System.Drawing.Size(116, 22);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stop.UseAccentColor = false;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Request Specific Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Controls.Add(this.Temp_Request, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.Kelembapan_Request, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.Pressure_Request, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.UV_Request, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.All_Request, 4, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 283);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(248, 29);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // Temp_Request
            // 
            this.Temp_Request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Temp_Request.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Temp_Request.Depth = 0;
            this.Temp_Request.HighEmphasis = true;
            this.Temp_Request.Icon = null;
            this.Temp_Request.Location = new System.Drawing.Point(4, 6);
            this.Temp_Request.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Temp_Request.MouseState = MaterialSkin.MouseState.HOVER;
            this.Temp_Request.Name = "Temp_Request";
            this.Temp_Request.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Temp_Request.Size = new System.Drawing.Size(41, 17);
            this.Temp_Request.TabIndex = 0;
            this.Temp_Request.Text = "T";
            this.Temp_Request.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Temp_Request.UseAccentColor = false;
            this.Temp_Request.UseVisualStyleBackColor = true;
            this.Temp_Request.Click += new System.EventHandler(this.Temp_Request_Click);
            // 
            // Kelembapan_Request
            // 
            this.Kelembapan_Request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kelembapan_Request.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Kelembapan_Request.Depth = 0;
            this.Kelembapan_Request.HighEmphasis = true;
            this.Kelembapan_Request.Icon = null;
            this.Kelembapan_Request.Location = new System.Drawing.Point(53, 6);
            this.Kelembapan_Request.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Kelembapan_Request.MouseState = MaterialSkin.MouseState.HOVER;
            this.Kelembapan_Request.Name = "Kelembapan_Request";
            this.Kelembapan_Request.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Kelembapan_Request.Size = new System.Drawing.Size(41, 17);
            this.Kelembapan_Request.TabIndex = 1;
            this.Kelembapan_Request.Text = "H";
            this.Kelembapan_Request.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Kelembapan_Request.UseAccentColor = false;
            this.Kelembapan_Request.UseVisualStyleBackColor = true;
            this.Kelembapan_Request.Click += new System.EventHandler(this.Kelembapan_Request_Click);
            // 
            // Pressure_Request
            // 
            this.Pressure_Request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pressure_Request.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Pressure_Request.Depth = 0;
            this.Pressure_Request.HighEmphasis = true;
            this.Pressure_Request.Icon = null;
            this.Pressure_Request.Location = new System.Drawing.Point(102, 6);
            this.Pressure_Request.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Pressure_Request.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pressure_Request.Name = "Pressure_Request";
            this.Pressure_Request.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Pressure_Request.Size = new System.Drawing.Size(41, 17);
            this.Pressure_Request.TabIndex = 2;
            this.Pressure_Request.Text = "P";
            this.Pressure_Request.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Pressure_Request.UseAccentColor = false;
            this.Pressure_Request.UseVisualStyleBackColor = true;
            this.Pressure_Request.Click += new System.EventHandler(this.Pressure_Request_Click);
            // 
            // UV_Request
            // 
            this.UV_Request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UV_Request.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UV_Request.Depth = 0;
            this.UV_Request.HighEmphasis = true;
            this.UV_Request.Icon = null;
            this.UV_Request.Location = new System.Drawing.Point(151, 6);
            this.UV_Request.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UV_Request.MouseState = MaterialSkin.MouseState.HOVER;
            this.UV_Request.Name = "UV_Request";
            this.UV_Request.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UV_Request.Size = new System.Drawing.Size(41, 17);
            this.UV_Request.TabIndex = 3;
            this.UV_Request.Text = "U";
            this.UV_Request.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UV_Request.UseAccentColor = false;
            this.UV_Request.UseVisualStyleBackColor = true;
            this.UV_Request.Click += new System.EventHandler(this.UV_Request_Click);
            // 
            // All_Request
            // 
            this.All_Request.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.All_Request.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.All_Request.Depth = 0;
            this.All_Request.HighEmphasis = true;
            this.All_Request.Icon = null;
            this.All_Request.Location = new System.Drawing.Point(200, 6);
            this.All_Request.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.All_Request.MouseState = MaterialSkin.MouseState.HOVER;
            this.All_Request.Name = "All_Request";
            this.All_Request.NoAccentTextColor = System.Drawing.Color.Empty;
            this.All_Request.Size = new System.Drawing.Size(44, 17);
            this.All_Request.TabIndex = 4;
            this.All_Request.Text = "A";
            this.All_Request.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.All_Request.UseAccentColor = false;
            this.All_Request.UseVisualStyleBackColor = true;
            this.All_Request.Click += new System.EventHandler(this.All_Request_Click);
            // 
            // groupReceived
            // 
            this.groupReceived.Controls.Add(this.tableLayoutPanel7);
            this.groupReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupReceived.Location = new System.Drawing.Point(251, 3);
            this.groupReceived.Name = "groupReceived";
            this.groupReceived.Size = new System.Drawing.Size(436, 410);
            this.groupReceived.TabIndex = 1;
            this.groupReceived.TabStop = false;
            this.groupReceived.Text = "Received Data";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.listReceived, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.Sending_msg, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(430, 391);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // listReceived
            // 
            this.listReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listReceived.Enabled = false;
            this.listReceived.FormattingEnabled = true;
            this.listReceived.Location = new System.Drawing.Point(3, 219);
            this.listReceived.Name = "listReceived";
            this.listReceived.Size = new System.Drawing.Size(424, 169);
            this.listReceived.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send Message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Received Message";
            // 
            // Sending_msg
            // 
            this.Sending_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sending_msg.FormattingEnabled = true;
            this.Sending_msg.Location = new System.Drawing.Point(3, 21);
            this.Sending_msg.Name = "Sending_msg";
            this.Sending_msg.Size = new System.Drawing.Size(424, 168);
            this.Sending_msg.TabIndex = 3;
            this.Sending_msg.SelectedIndexChanged += new System.EventHandler(this.Sending_msg_SelectedIndexChanged);
            // 
            // groupSerialSetting
            // 
            this.groupSerialSetting.Controls.Add(this.tableLayoutPanel3);
            this.groupSerialSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSerialSetting.Location = new System.Drawing.Point(3, 3);
            this.groupSerialSetting.Name = "groupSerialSetting";
            this.groupSerialSetting.Size = new System.Drawing.Size(242, 410);
            this.groupSerialSetting.TabIndex = 2;
            this.groupSerialSetting.TabStop = false;
            this.groupSerialSetting.Text = "Serial Port Setting";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Baudrate, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.PortName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.send_msgbox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.RecordGroup, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(236, 391);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Baudrate
            // 
            this.Baudrate.AutoResize = false;
            this.Baudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Baudrate.Depth = 0;
            this.Baudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Baudrate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Baudrate.DropDownHeight = 174;
            this.Baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Baudrate.DropDownWidth = 121;
            this.Baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Baudrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Baudrate.FormattingEnabled = true;
            this.Baudrate.Hint = "Baud Rate";
            this.Baudrate.IntegralHeight = false;
            this.Baudrate.ItemHeight = 43;
            this.Baudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "76800",
            "115200 "});
            this.Baudrate.Location = new System.Drawing.Point(3, 58);
            this.Baudrate.MaxDropDownItems = 4;
            this.Baudrate.MouseState = MaterialSkin.MouseState.OUT;
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(230, 49);
            this.Baudrate.StartIndex = 0;
            this.Baudrate.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.3913F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.6087F));
            this.tableLayoutPanel4.Controls.Add(this.connectbtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.materialButton1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(230, 38);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // connectbtn
            // 
            this.connectbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.connectbtn.Depth = 0;
            this.connectbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectbtn.HighEmphasis = true;
            this.connectbtn.Icon = null;
            this.connectbtn.Location = new System.Drawing.Point(4, 6);
            this.connectbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.connectbtn.Size = new System.Drawing.Size(123, 26);
            this.connectbtn.TabIndex = 0;
            this.connectbtn.Text = "Connect";
            this.connectbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.connectbtn.UseAccentColor = false;
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(135, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(91, 26);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Close";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // PortName
            // 
            this.PortName.AutoResize = false;
            this.PortName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PortName.Depth = 0;
            this.PortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PortName.DropDownHeight = 174;
            this.PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortName.DropDownWidth = 121;
            this.PortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PortName.FormattingEnabled = true;
            this.PortName.Hint = "Port Name";
            this.PortName.IntegralHeight = false;
            this.PortName.ItemHeight = 43;
            this.PortName.Location = new System.Drawing.Point(3, 3);
            this.PortName.MaxDropDownItems = 4;
            this.PortName.MouseState = MaterialSkin.MouseState.OUT;
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(230, 49);
            this.PortName.StartIndex = 0;
            this.PortName.TabIndex = 3;
            this.PortName.SelectedIndexChanged += new System.EventHandler(this.PortName_SelectedIndexChanged);
            this.PortName.Click += new System.EventHandler(this.PortName_Click);
            // 
            // send_msgbox
            // 
            this.send_msgbox.AnimateReadOnly = false;
            this.send_msgbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.send_msgbox.Depth = 0;
            this.send_msgbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_msgbox.Enabled = false;
            this.send_msgbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.send_msgbox.Hint = "Type Message";
            this.send_msgbox.LeadingIcon = null;
            this.send_msgbox.Location = new System.Drawing.Point(3, 157);
            this.send_msgbox.MaxLength = 50;
            this.send_msgbox.MouseState = MaterialSkin.MouseState.OUT;
            this.send_msgbox.Multiline = false;
            this.send_msgbox.Name = "send_msgbox";
            this.send_msgbox.Size = new System.Drawing.Size(230, 50);
            this.send_msgbox.TabIndex = 5;
            this.send_msgbox.Text = "";
            this.send_msgbox.TrailingIcon = null;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.delete_msg, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.send_msg, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 212);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(230, 38);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // delete_msg
            // 
            this.delete_msg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_msg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delete_msg.Depth = 0;
            this.delete_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_msg.Enabled = false;
            this.delete_msg.HighEmphasis = true;
            this.delete_msg.Icon = null;
            this.delete_msg.Location = new System.Drawing.Point(4, 6);
            this.delete_msg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_msg.Name = "delete_msg";
            this.delete_msg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delete_msg.Size = new System.Drawing.Size(107, 26);
            this.delete_msg.TabIndex = 0;
            this.delete_msg.Text = "Delete";
            this.delete_msg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete_msg.UseAccentColor = false;
            this.delete_msg.UseVisualStyleBackColor = true;
            this.delete_msg.Click += new System.EventHandler(this.delete_msg_Click);
            // 
            // send_msg
            // 
            this.send_msg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.send_msg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.send_msg.Depth = 0;
            this.send_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.send_msg.Enabled = false;
            this.send_msg.HighEmphasis = true;
            this.send_msg.Icon = null;
            this.send_msg.Location = new System.Drawing.Point(119, 6);
            this.send_msg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.send_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.send_msg.Name = "send_msg";
            this.send_msg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.send_msg.Size = new System.Drawing.Size(107, 26);
            this.send_msg.TabIndex = 1;
            this.send_msg.Text = "Send";
            this.send_msg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.send_msg.UseAccentColor = false;
            this.send_msg.UseVisualStyleBackColor = true;
            this.send_msg.Click += new System.EventHandler(this.send_msg_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // RecordGroup
            // 
            this.RecordGroup.Controls.Add(this.tableLayoutPanel9);
            this.RecordGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordGroup.Location = new System.Drawing.Point(3, 256);
            this.RecordGroup.Name = "RecordGroup";
            this.RecordGroup.Size = new System.Drawing.Size(230, 132);
            this.RecordGroup.TabIndex = 7;
            this.RecordGroup.TabStop = false;
            this.RecordGroup.Text = "Record Data";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(224, 113);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(218, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Record";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.5F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.5F));
            this.tableLayoutPanel10.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.fileCostumeName, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(218, 36);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "File Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileCostumeName
            // 
            this.fileCostumeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileCostumeName.Enabled = false;
            this.fileCostumeName.Location = new System.Drawing.Point(86, 3);
            this.fileCostumeName.Name = "fileCostumeName";
            this.fileCostumeName.Size = new System.Drawing.Size(129, 20);
            this.fileCostumeName.TabIndex = 1;
            this.fileCostumeName.TextChanged += new System.EventHandler(this.fileCostumeName_TextChanged);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.SlctFilePath, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.filePath, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(218, 37);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // SlctFilePath
            // 
            this.SlctFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SlctFilePath.Enabled = false;
            this.SlctFilePath.Location = new System.Drawing.Point(3, 3);
            this.SlctFilePath.Name = "SlctFilePath";
            this.SlctFilePath.Size = new System.Drawing.Size(76, 31);
            this.SlctFilePath.TabIndex = 0;
            this.SlctFilePath.Text = "Folder";
            this.SlctFilePath.UseVisualStyleBackColor = true;
            this.SlctFilePath.Click += new System.EventHandler(this.SlctFilePath_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePath.Enabled = false;
            this.filePath.Location = new System.Drawing.Point(85, 0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(130, 37);
            this.filePath.TabIndex = 1;
            this.filePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filePath.Click += new System.EventHandler(this.filePath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 443);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupSplitter.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupReceived.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupSerialSetting.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.RecordGroup.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupSplitter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox suhubox;
        private MaterialSkin.Controls.MaterialTextBox kelembapanbox;
        private MaterialSkin.Controls.MaterialTextBox tekananbox;
        private MaterialSkin.Controls.MaterialTextBox UVindexbox;
        private System.Windows.Forms.GroupBox groupReceived;
        private System.Windows.Forms.ListBox listReceived;
        private System.Windows.Forms.GroupBox groupSerialSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton connectbtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox Baudrate;
        private MaterialSkin.Controls.MaterialComboBox PortName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton stop;
        private MaterialSkin.Controls.MaterialTextBox send_msgbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialButton delete_msg;
        private MaterialSkin.Controls.MaterialButton send_msg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Sending_msg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialButton Temp_Request;
        private MaterialSkin.Controls.MaterialButton Kelembapan_Request;
        private MaterialSkin.Controls.MaterialButton Pressure_Request;
        private MaterialSkin.Controls.MaterialButton UV_Request;
        private MaterialSkin.Controls.MaterialButton All_Request;
        private System.Windows.Forms.GroupBox RecordGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileCostumeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button SlctFilePath;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

