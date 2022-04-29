namespace Tugas_Prak_11
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pengirim = new System.Windows.Forms.GroupBox();
            this.penerima = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Encryptbtn = new MaterialSkin.Controls.MaterialButton();
            this.senderKeylbl = new System.Windows.Forms.Label();
            this.senderKeybox = new System.Windows.Forms.TextBox();
            this.plainText = new System.Windows.Forms.GroupBox();
            this.senderText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.senderEncrypted = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DecryptedResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Decryptbtn = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reveiverKey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.receiveEncrypted = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pengirim.SuspendLayout();
            this.penerima.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.plainText.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pengirim, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.penerima, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pengirim
            // 
            this.pengirim.Controls.Add(this.tableLayoutPanel2);
            this.pengirim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pengirim.Location = new System.Drawing.Point(3, 3);
            this.pengirim.Name = "pengirim";
            this.pengirim.Size = new System.Drawing.Size(469, 355);
            this.pengirim.TabIndex = 0;
            this.pengirim.TabStop = false;
            this.pengirim.Text = "Pengirim";
            // 
            // penerima
            // 
            this.penerima.Controls.Add(this.tableLayoutPanel4);
            this.penerima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penerima.Location = new System.Drawing.Point(478, 3);
            this.penerima.Name = "penerima";
            this.penerima.Size = new System.Drawing.Size(470, 355);
            this.penerima.TabIndex = 1;
            this.penerima.TabStop = false;
            this.penerima.Text = "Penerima";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.plainText, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 336);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.Controls.Add(this.Encryptbtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.senderKeylbl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.senderKeybox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(457, 31);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Encryptbtn
            // 
            this.Encryptbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Encryptbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Encryptbtn.Depth = 0;
            this.Encryptbtn.HighEmphasis = true;
            this.Encryptbtn.Icon = null;
            this.Encryptbtn.Location = new System.Drawing.Point(371, 6);
            this.Encryptbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Encryptbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Encryptbtn.Name = "Encryptbtn";
            this.Encryptbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Encryptbtn.Size = new System.Drawing.Size(82, 19);
            this.Encryptbtn.TabIndex = 0;
            this.Encryptbtn.Text = "Encrypt";
            this.Encryptbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Encryptbtn.UseAccentColor = false;
            this.Encryptbtn.UseVisualStyleBackColor = true;
            this.Encryptbtn.Click += new System.EventHandler(this.Encryptbtn_Click);
            // 
            // senderKeylbl
            // 
            this.senderKeylbl.AutoSize = true;
            this.senderKeylbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderKeylbl.Location = new System.Drawing.Point(3, 0);
            this.senderKeylbl.Name = "senderKeylbl";
            this.senderKeylbl.Size = new System.Drawing.Size(103, 31);
            this.senderKeylbl.TabIndex = 1;
            this.senderKeylbl.Text = "Kunci Pengirim";
            this.senderKeylbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // senderKeybox
            // 
            this.senderKeybox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderKeybox.Location = new System.Drawing.Point(112, 3);
            this.senderKeybox.Multiline = true;
            this.senderKeybox.Name = "senderKeybox";
            this.senderKeybox.Size = new System.Drawing.Size(252, 25);
            this.senderKeybox.TabIndex = 2;
            this.senderKeybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plainText
            // 
            this.plainText.Controls.Add(this.senderText);
            this.plainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plainText.Location = new System.Drawing.Point(3, 40);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(457, 143);
            this.plainText.TabIndex = 1;
            this.plainText.TabStop = false;
            this.plainText.Text = "Plain Text";
            // 
            // senderText
            // 
            this.senderText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderText.Location = new System.Drawing.Point(3, 16);
            this.senderText.Multiline = true;
            this.senderText.Name = "senderText";
            this.senderText.Size = new System.Drawing.Size(451, 124);
            this.senderText.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.senderEncrypted);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypted Text Sending";
            // 
            // senderEncrypted
            // 
            this.senderEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderEncrypted.Location = new System.Drawing.Point(3, 16);
            this.senderEncrypted.Multiline = true;
            this.senderEncrypted.Name = "senderEncrypted";
            this.senderEncrypted.Size = new System.Drawing.Size(451, 125);
            this.senderEncrypted.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 336);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DecryptedResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypted Text";
            // 
            // DecryptedResult
            // 
            this.DecryptedResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptedResult.Location = new System.Drawing.Point(3, 16);
            this.DecryptedResult.Multiline = true;
            this.DecryptedResult.Name = "DecryptedResult";
            this.DecryptedResult.Size = new System.Drawing.Size(452, 125);
            this.DecryptedResult.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.Controls.Add(this.Decryptbtn, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.reveiverKey, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(458, 31);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Decryptbtn
            // 
            this.Decryptbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Decryptbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Decryptbtn.Depth = 0;
            this.Decryptbtn.HighEmphasis = true;
            this.Decryptbtn.Icon = null;
            this.Decryptbtn.Location = new System.Drawing.Point(372, 6);
            this.Decryptbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Decryptbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Decryptbtn.Name = "Decryptbtn";
            this.Decryptbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Decryptbtn.Size = new System.Drawing.Size(82, 19);
            this.Decryptbtn.TabIndex = 0;
            this.Decryptbtn.Text = "Decrypt";
            this.Decryptbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Decryptbtn.UseAccentColor = false;
            this.Decryptbtn.UseVisualStyleBackColor = true;
            this.Decryptbtn.Click += new System.EventHandler(this.Decryptbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kunci Penerima";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reveiverKey
            // 
            this.reveiverKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reveiverKey.Location = new System.Drawing.Point(112, 3);
            this.reveiverKey.Multiline = true;
            this.reveiverKey.Name = "reveiverKey";
            this.reveiverKey.Size = new System.Drawing.Size(253, 25);
            this.reveiverKey.TabIndex = 2;
            this.reveiverKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.receiveEncrypted);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received Encrypted Text";
            // 
            // receiveEncrypted
            // 
            this.receiveEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiveEncrypted.Location = new System.Drawing.Point(3, 16);
            this.receiveEncrypted.Multiline = true;
            this.receiveEncrypted.Name = "receiveEncrypted";
            this.receiveEncrypted.Size = new System.Drawing.Size(452, 124);
            this.receiveEncrypted.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 388);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pengirim.ResumeLayout(false);
            this.penerima.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.plainText.ResumeLayout(false);
            this.plainText.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox pengirim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton Encryptbtn;
        private System.Windows.Forms.Label senderKeylbl;
        private System.Windows.Forms.TextBox senderKeybox;
        private System.Windows.Forms.GroupBox penerima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox senderEncrypted;
        private System.Windows.Forms.GroupBox plainText;
        private System.Windows.Forms.TextBox senderText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DecryptedResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialButton Decryptbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reveiverKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox receiveEncrypted;
    }
}

