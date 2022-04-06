namespace Prak_5
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Setting = new MaterialSkin.Controls.MaterialLabel();
            this.Baud_Rate = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Connectbtn = new MaterialSkin.Controls.MaterialButton();
            this.Cancelbtn = new MaterialSkin.Controls.MaterialButton();
            this.PortName = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.sendbtn = new MaterialSkin.Controls.MaterialButton();
            this.sendtxt = new System.Windows.Forms.TextBox();
            this.boxview = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.baudratestatus = new System.Windows.Forms.Label();
            this.indicatorColor = new System.Windows.Forms.Label();
            this.Portstatus = new System.Windows.Forms.Label();
            this.clearbtn = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Setting, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Baud_Rate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.PortName, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(607, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.Depth = 0;
            this.Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Setting.Location = new System.Drawing.Point(3, 0);
            this.Setting.MouseState = MaterialSkin.MouseState.HOVER;
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(220, 37);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "Setting";
            this.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Baud_Rate
            // 
            this.Baud_Rate.AutoResize = false;
            this.Baud_Rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Baud_Rate.Depth = 0;
            this.Baud_Rate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Baud_Rate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Baud_Rate.DropDownHeight = 174;
            this.Baud_Rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Baud_Rate.DropDownWidth = 121;
            this.Baud_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Baud_Rate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Baud_Rate.FormattingEnabled = true;
            this.Baud_Rate.Hint = "Baud Rate";
            this.Baud_Rate.IntegralHeight = false;
            this.Baud_Rate.ItemHeight = 43;
            this.Baud_Rate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.Baud_Rate.Location = new System.Drawing.Point(3, 95);
            this.Baud_Rate.MaxDropDownItems = 4;
            this.Baud_Rate.MouseState = MaterialSkin.MouseState.OUT;
            this.Baud_Rate.Name = "Baud_Rate";
            this.Baud_Rate.Size = new System.Drawing.Size(220, 49);
            this.Baud_Rate.StartIndex = 3;
            this.Baud_Rate.TabIndex = 2;
            this.Baud_Rate.SelectedIndexChanged += new System.EventHandler(this.Baud_Rate_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Connectbtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Cancelbtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 150);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 36);
            this.tableLayoutPanel3.TabIndex = 3;
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
            this.Connectbtn.Size = new System.Drawing.Size(102, 24);
            this.Connectbtn.TabIndex = 0;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Connectbtn.UseAccentColor = false;
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Cancelbtn.Depth = 0;
            this.Cancelbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancelbtn.HighEmphasis = true;
            this.Cancelbtn.Icon = null;
            this.Cancelbtn.Location = new System.Drawing.Point(114, 6);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Cancelbtn.Size = new System.Drawing.Size(102, 24);
            this.Cancelbtn.TabIndex = 1;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cancelbtn.UseAccentColor = false;
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
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
            this.PortName.Hint = "Active Port";
            this.PortName.IntegralHeight = false;
            this.PortName.ItemHeight = 43;
            this.PortName.Location = new System.Drawing.Point(3, 40);
            this.PortName.MaxDropDownItems = 4;
            this.PortName.MouseState = MaterialSkin.MouseState.OUT;
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(220, 49);
            this.PortName.StartIndex = 0;
            this.PortName.TabIndex = 4;
            this.PortName.SelectedIndexChanged += new System.EventHandler(this.PortName_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.boxview, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(598, 360);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel5.Controls.Add(this.sendbtn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.sendtxt, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(592, 34);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // sendbtn
            // 
            this.sendbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendbtn.Depth = 0;
            this.sendbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendbtn.Enabled = false;
            this.sendbtn.HighEmphasis = true;
            this.sendbtn.Icon = null;
            this.sendbtn.Location = new System.Drawing.Point(511, 6);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendbtn.Size = new System.Drawing.Size(77, 22);
            this.sendbtn.TabIndex = 0;
            this.sendbtn.Text = "Send";
            this.sendbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendbtn.UseAccentColor = false;
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // sendtxt
            // 
            this.sendtxt.BackColor = System.Drawing.SystemColors.Control;
            this.sendtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendtxt.Enabled = false;
            this.sendtxt.Location = new System.Drawing.Point(3, 3);
            this.sendtxt.Multiline = true;
            this.sendtxt.Name = "sendtxt";
            this.sendtxt.Size = new System.Drawing.Size(501, 28);
            this.sendtxt.TabIndex = 1;
            this.sendtxt.TextChanged += new System.EventHandler(this.sendtxt_TextChanged);
            // 
            // boxview
            // 
            this.boxview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxview.Enabled = false;
            this.boxview.FormattingEnabled = true;
            this.boxview.Location = new System.Drawing.Point(3, 43);
            this.boxview.Name = "boxview";
            this.boxview.Size = new System.Drawing.Size(592, 277);
            this.boxview.TabIndex = 1;
            this.boxview.SelectedIndexChanged += new System.EventHandler(this.boxview_SelectedIndexChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel6.Controls.Add(this.baudratestatus, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.indicatorColor, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Portstatus, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.clearbtn, 4, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 326);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(592, 31);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // baudratestatus
            // 
            this.baudratestatus.AutoSize = true;
            this.baudratestatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudratestatus.Location = new System.Drawing.Point(183, 0);
            this.baudratestatus.Name = "baudratestatus";
            this.baudratestatus.Size = new System.Drawing.Size(144, 31);
            this.baudratestatus.TabIndex = 2;
            this.baudratestatus.Text = "Baud Rate : -";
            this.baudratestatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baudratestatus.Click += new System.EventHandler(this.baudratestatus_Click);
            // 
            // indicatorColor
            // 
            this.indicatorColor.AutoSize = true;
            this.indicatorColor.BackColor = System.Drawing.Color.Red;
            this.indicatorColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indicatorColor.Location = new System.Drawing.Point(3, 0);
            this.indicatorColor.Name = "indicatorColor";
            this.indicatorColor.Size = new System.Drawing.Size(24, 31);
            this.indicatorColor.TabIndex = 0;
            this.indicatorColor.Click += new System.EventHandler(this.indicatorColor_Click);
            // 
            // Portstatus
            // 
            this.Portstatus.AutoSize = true;
            this.Portstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Portstatus.Location = new System.Drawing.Point(33, 0);
            this.Portstatus.Name = "Portstatus";
            this.Portstatus.Size = new System.Drawing.Size(144, 31);
            this.Portstatus.TabIndex = 1;
            this.Portstatus.Text = "Port Name : -";
            this.Portstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Portstatus.Click += new System.EventHandler(this.Portstatus_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearbtn.Depth = 0;
            this.clearbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearbtn.Enabled = false;
            this.clearbtn.HighEmphasis = true;
            this.clearbtn.Icon = null;
            this.clearbtn.Location = new System.Drawing.Point(511, 6);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearbtn.Size = new System.Drawing.Size(77, 19);
            this.clearbtn.TabIndex = 3;
            this.clearbtn.Text = "Clear";
            this.clearbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearbtn.UseAccentColor = false;
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 393);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel Setting;
        private MaterialSkin.Controls.MaterialComboBox Baud_Rate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton Connectbtn;
        private MaterialSkin.Controls.MaterialButton Cancelbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialButton sendbtn;
        private System.Windows.Forms.TextBox sendtxt;
        private System.Windows.Forms.ListBox boxview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label indicatorColor;
        private System.Windows.Forms.Label baudratestatus;
        private System.Windows.Forms.Label Portstatus;
        private MaterialSkin.Controls.MaterialComboBox PortName;
        private MaterialSkin.Controls.MaterialButton clearbtn;

    }
}

