namespace YouTube___Download
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
            this.GetImageButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.videoID = new System.Windows.Forms.TextBox();
            this.videoIDText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Default = new System.Windows.Forms.RadioButton();
            this.MqDefault = new System.Windows.Forms.RadioButton();
            this.HqDefault = new System.Windows.Forms.RadioButton();
            this.SdDefault = new System.Windows.Forms.RadioButton();
            this.MaxResDefault = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetImageButton
            // 
            this.GetImageButton.Location = new System.Drawing.Point(287, 208);
            this.GetImageButton.Name = "GetImageButton";
            this.GetImageButton.Size = new System.Drawing.Size(89, 35);
            this.GetImageButton.TabIndex = 1;
            this.GetImageButton.Text = "Get Image";
            this.GetImageButton.UseVisualStyleBackColor = true;
            this.GetImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(166, 86);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(89, 35);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download Image";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // videoID
            // 
            this.videoID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.videoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videoID.Location = new System.Drawing.Point(109, 208);
            this.videoID.MaxLength = 15;
            this.videoID.Multiline = true;
            this.videoID.Name = "videoID";
            this.videoID.Size = new System.Drawing.Size(176, 35);
            this.videoID.TabIndex = 3;
            this.videoID.TextChanged += new System.EventHandler(this.videoID_TextChanged_1);
            // 
            // videoIDText
            // 
            this.videoIDText.AutoSize = true;
            this.videoIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videoIDText.Location = new System.Drawing.Point(12, 211);
            this.videoIDText.Name = "videoIDText";
            this.videoIDText.Size = new System.Drawing.Size(87, 24);
            this.videoIDText.TabIndex = 4;
            this.videoIDText.Text = "Video ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::YouTube___Download.Properties.Resources._404err;
            this.pictureBox1.ImageLocation = "https://i1.ytimg.com/vi/IyBKTVGCS7Q/maxresdefault.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Default
            // 
            this.Default.AutoSize = true;
            this.Default.Location = new System.Drawing.Point(6, 6);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(66, 17);
            this.Default.TabIndex = 5;
            this.Default.Text = "120 x 90";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.CheckedChanged += new System.EventHandler(this.Default_CheckedChanged);
            // 
            // MqDefault
            // 
            this.MqDefault.AutoSize = true;
            this.MqDefault.Location = new System.Drawing.Point(6, 29);
            this.MqDefault.Name = "MqDefault";
            this.MqDefault.Size = new System.Drawing.Size(72, 17);
            this.MqDefault.TabIndex = 6;
            this.MqDefault.Text = "320 x 180";
            this.MqDefault.UseVisualStyleBackColor = true;
            this.MqDefault.CheckedChanged += new System.EventHandler(this.MqDefault_CheckedChanged);
            // 
            // HqDefault
            // 
            this.HqDefault.AutoSize = true;
            this.HqDefault.Location = new System.Drawing.Point(6, 52);
            this.HqDefault.Name = "HqDefault";
            this.HqDefault.Size = new System.Drawing.Size(72, 17);
            this.HqDefault.TabIndex = 7;
            this.HqDefault.Text = "480 x 360";
            this.HqDefault.UseVisualStyleBackColor = true;
            this.HqDefault.CheckedChanged += new System.EventHandler(this.HqDefault_CheckedChanged);
            // 
            // SdDefault
            // 
            this.SdDefault.AutoSize = true;
            this.SdDefault.Location = new System.Drawing.Point(106, 6);
            this.SdDefault.Name = "SdDefault";
            this.SdDefault.Size = new System.Drawing.Size(72, 17);
            this.SdDefault.TabIndex = 8;
            this.SdDefault.Text = "640 x 480";
            this.SdDefault.UseVisualStyleBackColor = true;
            this.SdDefault.CheckedChanged += new System.EventHandler(this.SdDefault_CheckedChanged);
            // 
            // MaxResDefault
            // 
            this.MaxResDefault.AutoSize = true;
            this.MaxResDefault.Checked = true;
            this.MaxResDefault.Location = new System.Drawing.Point(106, 29);
            this.MaxResDefault.Name = "MaxResDefault";
            this.MaxResDefault.Size = new System.Drawing.Size(84, 17);
            this.MaxResDefault.TabIndex = 9;
            this.MaxResDefault.TabStop = true;
            this.MaxResDefault.Text = "1920 x 1080";
            this.MaxResDefault.UseVisualStyleBackColor = true;
            this.MaxResDefault.CheckedChanged += new System.EventHandler(this.MaxResDefault_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(105, 253);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 153);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Default);
            this.tabPage1.Controls.Add(this.MaxResDefault);
            this.tabPage1.Controls.Add(this.MqDefault);
            this.tabPage1.Controls.Add(this.DownloadButton);
            this.tabPage1.Controls.Add(this.SdDefault);
            this.tabPage1.Controls.Add(this.HqDefault);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Quality";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ferhat Özkan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.videoIDText);
            this.Controls.Add(this.videoID);
            this.Controls.Add(this.GetImageButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Image Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox videoID;
        private System.Windows.Forms.Label videoIDText;
        private System.Windows.Forms.Button GetImageButton;
        private System.Windows.Forms.RadioButton Default;
        private System.Windows.Forms.RadioButton MqDefault;
        private System.Windows.Forms.RadioButton HqDefault;
        private System.Windows.Forms.RadioButton SdDefault;
        private System.Windows.Forms.RadioButton MaxResDefault;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
    }
}

