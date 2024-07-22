
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
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numRepeat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.cbReloadRegion = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRealTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numMinDelay = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numMaxDelay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpam)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(241, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(12, 63);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(643, 267);
            this.dgvAccount.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(623, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(81, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(536, 20);
            this.txtPath.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn file\r\ntài khoản:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số tài khoản:";
            // 
            // lblNumAccount
            // 
            this.lblNumAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumAccount.AutoSize = true;
            this.lblNumAccount.Location = new System.Drawing.Point(86, 336);
            this.lblNumAccount.Name = "lblNumAccount";
            this.lblNumAccount.Size = new System.Drawing.Size(0, 13);
            this.lblNumAccount.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(12, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hướng dẫn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenAccount.Location = new System.Drawing.Point(112, 530);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(93, 23);
            this.btnOpenAccount.TabIndex = 14;
            this.btnOpenAccount.Text = "Mở file account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(552, 546);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright by ThanhDB";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnHenGio);
            this.groupBox1.Controls.Add(this.dtHenGio);
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
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
            this.cbSpam.CheckedChanged += new System.EventHandler(this.cbSpam_CheckedChanged);
            // 
            // numSpam
            // 
            this.numSpam.Location = new System.Drawing.Point(65, 41);
            this.numSpam.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSpam.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSpam.Name = "numSpam";
            this.numSpam.Size = new System.Drawing.Size(45, 20);
            this.numSpam.TabIndex = 19;
            this.numSpam.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numMaxDelay);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numMinDelay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbRepeat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numRepeat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numDelay);
            this.groupBox2.Controls.Add(this.cbReloadRegion);
            this.groupBox2.Controls.Add(this.cbReload);
            this.groupBox2.Controls.Add(this.numSpam);
            this.groupBox2.Controls.Add(this.cbSpam);
            this.groupBox2.Location = new System.Drawing.Point(403, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 203);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(6, 127);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(44, 17);
            this.cbRepeat.TabIndex = 26;
            this.cbRepeat.Text = "Lặp";
            this.cbRepeat.UseVisualStyleBackColor = true;
            this.cbRepeat.CheckedChanged += new System.EventHandler(this.cbRepeat_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "lần";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Số lần lặp:";
            // 
            // numRepeat
            // 
            this.numRepeat.Location = new System.Drawing.Point(70, 176);
            this.numRepeat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numRepeat.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRepeat.Name = "numRepeat";
            this.numRepeat.Size = new System.Drawing.Size(44, 20);
            this.numRepeat.TabIndex = 24;
            this.numRepeat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "giây";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Lặp lại sau:";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(70, 150);
            this.numDelay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(44, 20);
            this.numDelay.TabIndex = 21;
            this.numDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbReloadRegion
            // 
            this.cbReloadRegion.AutoSize = true;
            this.cbReloadRegion.Location = new System.Drawing.Point(6, 104);
            this.cbReloadRegion.Name = "cbReloadRegion";
            this.cbReloadRegion.Size = new System.Drawing.Size(134, 17);
            this.cbReloadRegion.TabIndex = 20;
            this.cbReloadRegion.Text = "Reload đến khi CN mở";
            this.cbReloadRegion.UseVisualStyleBackColor = true;
            this.cbReloadRegion.CheckedChanged += new System.EventHandler(this.cbReloadRegion_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(241, 466);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(127, 46);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblRealTime
            // 
            this.lblRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRealTime.AutoSize = true;
            this.lblRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealTime.Location = new System.Drawing.Point(12, 484);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(46, 18);
            this.lblRealTime.TabIndex = 22;
            this.lblRealTime.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Delay từ";
            // 
            // numMinDelay
            // 
            this.numMinDelay.Location = new System.Drawing.Point(65, 73);
            this.numMinDelay.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numMinDelay.Name = "numMinDelay";
            this.numMinDelay.Size = new System.Drawing.Size(45, 20);
            this.numMinDelay.TabIndex = 28;
            this.numMinDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "(s)";
            // 
            // numMaxDelay
            // 
            this.numMaxDelay.Location = new System.Drawing.Point(127, 73);
            this.numMaxDelay.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numMaxDelay.Name = "numMaxDelay";
            this.numMaxDelay.Size = new System.Drawing.Size(45, 20);
            this.numMaxDelay.TabIndex = 31;
            this.numMaxDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "lần";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 565);
            this.Controls.Add(this.lblRealTime);
            this.Controls.Add(this.btnStop);
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
            this.Text = "Auto Buy Gold SJC v1.8";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSpam)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDelay)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numRepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Label lblRealTime;
        private System.Windows.Forms.NumericUpDown numMaxDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMinDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}

