
namespace AutoBuySJC
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumAccount = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHenGio = new System.Windows.Forms.Button();
            this.dtHenGio = new System.Windows.Forms.DateTimePicker();
            this.cbReload = new System.Windows.Forms.CheckBox();
            this.cbSpam = new System.Windows.Forms.CheckBox();
            this.numSpam = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbReloadRegion = new System.Windows.Forms.CheckBox();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpam)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(225, 343);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(16, 67);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(499, 195);
            this.dgvAccount.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(81, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(393, 20);
            this.txtPath.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn file\r\ntài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số tài khoản:";
            // 
            // lblNumAccount
            // 
            this.lblNumAccount.AutoSize = true;
            this.lblNumAccount.Location = new System.Drawing.Point(86, 271);
            this.lblNumAccount.Name = "lblNumAccount";
            this.lblNumAccount.Size = new System.Drawing.Size(0, 13);
            this.lblNumAccount.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hướng dẫn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(124, 414);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(93, 23);
            this.btnOpenAccount.TabIndex = 14;
            this.btnOpenAccount.Text = "Mở file account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(406, 436);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright by ThanhDB";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHenGio);
            this.groupBox1.Controls.Add(this.dtHenGio);
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hẹn giờ";
            // 
            // btnHenGio
            // 
            this.btnHenGio.Location = new System.Drawing.Point(53, 47);
            this.btnHenGio.Name = "btnHenGio";
            this.btnHenGio.Size = new System.Drawing.Size(75, 23);
            this.btnHenGio.TabIndex = 1;
            this.btnHenGio.Text = "Hẹn giờ";
            this.btnHenGio.UseVisualStyleBackColor = true;
            this.btnHenGio.Click += new System.EventHandler(this.btnHenGio_Click);
            // 
            // dtHenGio
            // 
            this.dtHenGio.CustomFormat = "dd/MM/yyy hh:mm:ss";
            this.dtHenGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHenGio.Location = new System.Drawing.Point(6, 19);
            this.dtHenGio.Name = "dtHenGio";
            this.dtHenGio.Size = new System.Drawing.Size(169, 20);
            this.dtHenGio.TabIndex = 0;
            // 
            // cbReload
            // 
            this.cbReload.AutoSize = true;
            this.cbReload.Location = new System.Drawing.Point(6, 20);
            this.cbReload.Name = "cbReload";
            this.cbReload.Size = new System.Drawing.Size(148, 17);
            this.cbReload.TabIndex = 17;
            this.cbReload.Text = "F5 đến khi sang ngày mới";
            this.cbReload.UseVisualStyleBackColor = true;
            // 
            // cbSpam
            // 
            this.cbSpam.AutoSize = true;
            this.cbSpam.Location = new System.Drawing.Point(6, 43);
            this.cbSpam.Name = "cbSpam";
            this.cbSpam.Size = new System.Drawing.Size(53, 17);
            this.cbSpam.TabIndex = 18;
            this.cbSpam.Text = "Spam";
            this.cbSpam.UseVisualStyleBackColor = true;
            // 
            // numSpam
            // 
            this.numSpam.Location = new System.Drawing.Point(65, 42);
            this.numSpam.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSpam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpam.Name = "numSpam";
            this.numSpam.Size = new System.Drawing.Size(45, 20);
            this.numSpam.TabIndex = 19;
            this.numSpam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxRegion);
            this.groupBox2.Controls.Add(this.cbReloadRegion);
            this.groupBox2.Controls.Add(this.cbReload);
            this.groupBox2.Controls.Add(this.numSpam);
            this.groupBox2.Controls.Add(this.cbSpam);
            this.groupBox2.Location = new System.Drawing.Point(353, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 128);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // cbReloadRegion
            // 
            this.cbReloadRegion.AutoSize = true;
            this.cbReloadRegion.Location = new System.Drawing.Point(6, 66);
            this.cbReloadRegion.Name = "cbReloadRegion";
            this.cbReloadRegion.Size = new System.Drawing.Size(145, 17);
            this.cbReloadRegion.TabIndex = 20;
            this.cbReloadRegion.Text = "Reload đến khi phiên mở";
            this.cbReloadRegion.UseVisualStyleBackColor = true;
            this.cbReloadRegion.CheckedChanged += new System.EventHandler(this.cbReloadRegion_CheckedChanged);
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Items.AddRange(new object[] {
            "Thành phố Hà Nội",
            "Thành phố Hồ Chí Minh"});
            this.cbxRegion.Location = new System.Drawing.Point(23, 89);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(115, 21);
            this.cbxRegion.TabIndex = 21;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblNumAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Buy Gold SJC v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSpam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumAccount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtHenGio;
        private System.Windows.Forms.Button btnHenGio;
        private System.Windows.Forms.CheckBox cbReload;
        private System.Windows.Forms.CheckBox cbSpam;
        private System.Windows.Forms.NumericUpDown numSpam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbReloadRegion;
        private System.Windows.Forms.ComboBox cbxRegion;
    }
}

