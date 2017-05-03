﻿namespace EarthLiveSharp
{
    partial class settingsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.version_number = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autostart = new System.Windows.Forms.CheckBox();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Orgin = new System.Windows.Forms.RadioButton();
            this.radioButton_CDN = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cloud_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.image_zoom = new System.Windows.Forms.NumericUpDown();
            this.image_size = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.api_key = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.api_secret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_zoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(62, 366);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 15);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "check upgrade";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 354);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // version_number
            // 
            this.version_number.AutoSize = true;
            this.version_number.Location = new System.Drawing.Point(16, 366);
            this.version_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version_number.Name = "version_number";
            this.version_number.Size = new System.Drawing.Size(39, 15);
            this.version_number.TabIndex = 12;
            this.version_number.Text = "v0.0";
            this.version_number.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autostart
            // 
            this.autostart.AutoSize = true;
            this.autostart.Location = new System.Drawing.Point(213, 110);
            this.autostart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autostart.Name = "autostart";
            this.autostart.Size = new System.Drawing.Size(18, 17);
            this.autostart.TabIndex = 5;
            this.autostart.UseVisualStyleBackColor = true;
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(213, 78);
            this.interval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interval.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.ReadOnly = true;
            this.interval.Size = new System.Drawing.Size(122, 25);
            this.interval.TabIndex = 2;
            this.interval.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autostart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update Interval (minutes)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Source";
            // 
            // radioButton_Orgin
            // 
            this.radioButton_Orgin.AutoSize = true;
            this.radioButton_Orgin.Location = new System.Drawing.Point(213, 136);
            this.radioButton_Orgin.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Orgin.Name = "radioButton_Orgin";
            this.radioButton_Orgin.Size = new System.Drawing.Size(68, 19);
            this.radioButton_Orgin.TabIndex = 8;
            this.radioButton_Orgin.TabStop = true;
            this.radioButton_Orgin.Text = "Orgin";
            this.radioButton_Orgin.UseVisualStyleBackColor = true;
            this.radioButton_Orgin.CheckedChanged += new System.EventHandler(this.radioButton_Orgin_CheckedChanged);
            // 
            // radioButton_CDN
            // 
            this.radioButton_CDN.AutoSize = true;
            this.radioButton_CDN.Location = new System.Drawing.Point(213, 161);
            this.radioButton_CDN.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_CDN.Name = "radioButton_CDN";
            this.radioButton_CDN.Size = new System.Drawing.Size(172, 19);
            this.radioButton_CDN.TabIndex = 8;
            this.radioButton_CDN.TabStop = true;
            this.radioButton_CDN.Text = "CDN (recommended!)";
            this.radioButton_CDN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cloud Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cloud_name
            // 
            this.cloud_name.Location = new System.Drawing.Point(213, 15);
            this.cloud_name.Margin = new System.Windows.Forms.Padding(2);
            this.cloud_name.Name = "cloud_name";
            this.cloud_name.Size = new System.Drawing.Size(123, 25);
            this.cloud_name.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.image_zoom);
            this.panel1.Controls.Add(this.image_size);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButton_CDN);
            this.panel1.Controls.Add(this.radioButton_Orgin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.interval);
            this.panel1.Controls.Add(this.autostart);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 191);
            this.panel1.TabIndex = 11;
            this.panel1.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Wallpaper Zoom (%)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image_zoom
            // 
            this.image_zoom.Location = new System.Drawing.Point(213, 41);
            this.image_zoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.image_zoom.Minimum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.image_zoom.Name = "image_zoom";
            this.image_zoom.ReadOnly = true;
            this.image_zoom.Size = new System.Drawing.Size(122, 25);
            this.image_zoom.TabIndex = 14;
            this.image_zoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // image_size
            // 
            this.image_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.image_size.FormattingEnabled = true;
            this.image_size.Items.AddRange(new object[] {
            "550*550",
            "1100*1100",
            "2200*2200",
            "4400*4400",
            "8800*8800"});
            this.image_size.Location = new System.Drawing.Point(213, 9);
            this.image_size.Margin = new System.Windows.Forms.Padding(2);
            this.image_size.Name = "image_size";
            this.image_size.Size = new System.Drawing.Size(124, 23);
            this.image_size.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Image Quality (pixels)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // api_key
            // 
            this.api_key.Location = new System.Drawing.Point(213, 61);
            this.api_key.Margin = new System.Windows.Forms.Padding(2);
            this.api_key.Name = "api_key";
            this.api_key.Size = new System.Drawing.Size(123, 25);
            this.api_key.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "API Key";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(128, 44);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(215, 15);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "(How to get a cloud name?)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // api_secret
            // 
            this.api_secret.Location = new System.Drawing.Point(213, 92);
            this.api_secret.Margin = new System.Windows.Forms.Padding(2);
            this.api_secret.Name = "api_secret";
            this.api_secret.Size = new System.Drawing.Size(123, 25);
            this.api_secret.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "API Secret";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.api_secret);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.api_key);
            this.panel2.Controls.Add(this.cloud_name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Location = new System.Drawing.Point(15, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 132);
            this.panel2.TabIndex = 15;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(421, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.version_number);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.ShowInTaskbar = false;
            this.Text = "settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.settingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_zoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label version_number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox autostart;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Orgin;
        private System.Windows.Forms.RadioButton radioButton_CDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cloud_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox image_size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown image_zoom;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox api_key;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox api_secret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
    }
}

