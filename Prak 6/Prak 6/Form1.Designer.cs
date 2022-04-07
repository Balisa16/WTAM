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
            this.groupReceived = new System.Windows.Forms.GroupBox();
            this.listReceived = new System.Windows.Forms.ListBox();
            this.groupSerialSetting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.connectbtn = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.PortName = new MaterialSkin.Controls.MaterialComboBox();
            this.Baudrate = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupSplitter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupReceived.SuspendLayout();
            this.groupSerialSetting.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupSplitter
            // 
            this.groupSplitter.Controls.Add(this.tableLayoutPanel2);
            this.groupSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSplitter.Location = new System.Drawing.Point(594, 3);
            this.groupSplitter.Name = "groupSplitter";
            this.groupSplitter.Size = new System.Drawing.Size(260, 303);
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 284);
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
            // groupReceived
            // 
            this.groupReceived.Controls.Add(this.listReceived);
            this.groupReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupReceived.Location = new System.Drawing.Point(251, 3);
            this.groupReceived.Name = "groupReceived";
            this.groupReceived.Size = new System.Drawing.Size(337, 303);
            this.groupReceived.TabIndex = 1;
            this.groupReceived.TabStop = false;
            this.groupReceived.Text = "Received Data";
            // 
            // listReceived
            // 
            this.listReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listReceived.Enabled = false;
            this.listReceived.FormattingEnabled = true;
            this.listReceived.Location = new System.Drawing.Point(3, 16);
            this.listReceived.Name = "listReceived";
            this.listReceived.Size = new System.Drawing.Size(331, 284);
            this.listReceived.TabIndex = 0;
            // 
            // groupSerialSetting
            // 
            this.groupSerialSetting.Controls.Add(this.tableLayoutPanel3);
            this.groupSerialSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSerialSetting.Location = new System.Drawing.Point(3, 3);
            this.groupSerialSetting.Name = "groupSerialSetting";
            this.groupSerialSetting.Size = new System.Drawing.Size(242, 303);
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(236, 284);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
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
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.connectbtn.Size = new System.Drawing.Size(124, 26);
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
            this.materialButton1.Location = new System.Drawing.Point(136, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(90, 26);
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
            this.PortName.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
            "115200"});
            this.Baudrate.Location = new System.Drawing.Point(3, 58);
            this.Baudrate.MaxDropDownItems = 4;
            this.Baudrate.MouseState = MaterialSkin.MouseState.OUT;
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(230, 49);
            this.Baudrate.StartIndex = 0;
            this.Baudrate.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 336);
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
            this.groupReceived.ResumeLayout(false);
            this.groupSerialSetting.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
    }
}

