namespace Prak_10
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
            this.IsiFileGroup = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SerialPortSettingGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.sendBtn = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.baudratelist = new MaterialSkin.Controls.MaterialComboBox();
            this.baudrate_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comPortlbl = new MaterialSkin.Controls.MaterialLabel();
            this.COMPortlist = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Closebtn = new MaterialSkin.Controls.MaterialButton();
            this.Connectbtn = new MaterialSkin.Controls.MaterialButton();
            this.SelectedFilelbl = new System.Windows.Forms.Label();
            this.fileInpo = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.IsiFileGroup.SuspendLayout();
            this.SerialPortSettingGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.IsiFileGroup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SerialPortSettingGroup, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IsiFileGroup
            // 
            this.IsiFileGroup.Controls.Add(this.listBox1);
            this.IsiFileGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IsiFileGroup.Location = new System.Drawing.Point(342, 3);
            this.IsiFileGroup.Name = "IsiFileGroup";
            this.IsiFileGroup.Size = new System.Drawing.Size(482, 424);
            this.IsiFileGroup.TabIndex = 0;
            this.IsiFileGroup.TabStop = false;
            this.IsiFileGroup.Text = "Isi File";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(476, 405);
            this.listBox1.TabIndex = 0;
            // 
            // SerialPortSettingGroup
            // 
            this.SerialPortSettingGroup.Controls.Add(this.tableLayoutPanel2);
            this.SerialPortSettingGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SerialPortSettingGroup.Location = new System.Drawing.Point(3, 3);
            this.SerialPortSettingGroup.Name = "SerialPortSettingGroup";
            this.SerialPortSettingGroup.Size = new System.Drawing.Size(333, 424);
            this.SerialPortSettingGroup.TabIndex = 1;
            this.SerialPortSettingGroup.TabStop = false;
            this.SerialPortSettingGroup.Text = "Serial Port Setting";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SelectedFilelbl, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.fileInpo, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(327, 405);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.63348F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36652F));
            this.tableLayoutPanel6.Controls.Add(this.sendBtn, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.selectFile, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(321, 34);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendBtn.Enabled = false;
            this.sendBtn.Location = new System.Drawing.Point(197, 3);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(121, 28);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // selectFile
            // 
            this.selectFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFile.Enabled = false;
            this.selectFile.Location = new System.Drawing.Point(3, 3);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(188, 28);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.baudratelist, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.baudrate_lbl, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(321, 49);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // baudratelist
            // 
            this.baudratelist.AutoResize = false;
            this.baudratelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.baudratelist.Depth = 0;
            this.baudratelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudratelist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.baudratelist.DropDownHeight = 174;
            this.baudratelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudratelist.DropDownWidth = 121;
            this.baudratelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.baudratelist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baudratelist.FormattingEnabled = true;
            this.baudratelist.IntegralHeight = false;
            this.baudratelist.ItemHeight = 43;
            this.baudratelist.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "76800",
            "115200 "});
            this.baudratelist.Location = new System.Drawing.Point(94, 3);
            this.baudratelist.MaxDropDownItems = 4;
            this.baudratelist.MouseState = MaterialSkin.MouseState.OUT;
            this.baudratelist.Name = "baudratelist";
            this.baudratelist.Size = new System.Drawing.Size(224, 49);
            this.baudratelist.StartIndex = 0;
            this.baudratelist.TabIndex = 2;
            // 
            // baudrate_lbl
            // 
            this.baudrate_lbl.AutoSize = true;
            this.baudrate_lbl.Depth = 0;
            this.baudrate_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudrate_lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.baudrate_lbl.Location = new System.Drawing.Point(3, 0);
            this.baudrate_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.baudrate_lbl.Name = "baudrate_lbl";
            this.baudrate_lbl.Size = new System.Drawing.Size(85, 49);
            this.baudrate_lbl.TabIndex = 1;
            this.baudrate_lbl.Text = "Baud Rate";
            this.baudrate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.comPortlbl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.COMPortlist, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 49);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // comPortlbl
            // 
            this.comPortlbl.AutoSize = true;
            this.comPortlbl.Depth = 0;
            this.comPortlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comPortlbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comPortlbl.Location = new System.Drawing.Point(3, 0);
            this.comPortlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.comPortlbl.Name = "comPortlbl";
            this.comPortlbl.Size = new System.Drawing.Size(85, 49);
            this.comPortlbl.TabIndex = 0;
            this.comPortlbl.Text = "COM Port";
            this.comPortlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // COMPortlist
            // 
            this.COMPortlist.AutoResize = false;
            this.COMPortlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.COMPortlist.Depth = 0;
            this.COMPortlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMPortlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.COMPortlist.DropDownHeight = 174;
            this.COMPortlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortlist.DropDownWidth = 121;
            this.COMPortlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.COMPortlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.COMPortlist.FormattingEnabled = true;
            this.COMPortlist.IntegralHeight = false;
            this.COMPortlist.ItemHeight = 43;
            this.COMPortlist.Location = new System.Drawing.Point(94, 3);
            this.COMPortlist.MaxDropDownItems = 4;
            this.COMPortlist.MouseState = MaterialSkin.MouseState.OUT;
            this.COMPortlist.Name = "COMPortlist";
            this.COMPortlist.Size = new System.Drawing.Size(224, 49);
            this.COMPortlist.StartIndex = 0;
            this.COMPortlist.TabIndex = 1;
            this.COMPortlist.Click += new System.EventHandler(this.COMPort_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Closebtn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Connectbtn, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(321, 34);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Closebtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Closebtn.Depth = 0;
            this.Closebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Closebtn.HighEmphasis = true;
            this.Closebtn.Icon = null;
            this.Closebtn.Location = new System.Drawing.Point(164, 6);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Closebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Closebtn.Size = new System.Drawing.Size(153, 22);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "Close";
            this.Closebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Closebtn.UseAccentColor = false;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Connectbtn
            // 
            this.Connectbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Connectbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Connectbtn.Depth = 0;
            this.Connectbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Connectbtn.HighEmphasis = true;
            this.Connectbtn.Icon = null;
            this.Connectbtn.Location = new System.Drawing.Point(4, 6);
            this.Connectbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Connectbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Connectbtn.Size = new System.Drawing.Size(152, 22);
            this.Connectbtn.TabIndex = 0;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Connectbtn.UseAccentColor = false;
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // SelectedFilelbl
            // 
            this.SelectedFilelbl.AutoSize = true;
            this.SelectedFilelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedFilelbl.Enabled = false;
            this.SelectedFilelbl.Location = new System.Drawing.Point(3, 190);
            this.SelectedFilelbl.Name = "SelectedFilelbl";
            this.SelectedFilelbl.Size = new System.Drawing.Size(321, 23);
            this.SelectedFilelbl.TabIndex = 4;
            this.SelectedFilelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileInpo
            // 
            this.fileInpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInpo.FormattingEnabled = true;
            this.fileInpo.HorizontalScrollbar = true;
            this.fileInpo.Location = new System.Drawing.Point(3, 216);
            this.fileInpo.Name = "fileInpo";
            this.fileInpo.Size = new System.Drawing.Size(321, 186);
            this.fileInpo.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.IsiFileGroup.ResumeLayout(false);
            this.SerialPortSettingGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox IsiFileGroup;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox SerialPortSettingGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialComboBox baudratelist;
        private MaterialSkin.Controls.MaterialLabel baudrate_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel comPortlbl;
        private MaterialSkin.Controls.MaterialComboBox COMPortlist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialButton Closebtn;
        private MaterialSkin.Controls.MaterialButton Connectbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label SelectedFilelbl;
        private System.Windows.Forms.ListBox fileInpo;
    }
}

