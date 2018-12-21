namespace RailoNailo
{
    partial class TourListDetail
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.tbxOverView = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLblHomePage = new System.Windows.Forms.LinkLabel();
            this.pbxPlusImg = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.plusImageTrackBar = new System.Windows.Forms.TrackBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlusImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusImageTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.BackColor = System.Drawing.Color.Transparent;
            this.lblAddr.Location = new System.Drawing.Point(630, 108);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(52, 12);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "Address";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.BackColor = System.Drawing.Color.Transparent;
            this.lblZipcode.Location = new System.Drawing.Point(654, 140);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(51, 12);
            this.lblZipcode.TabIndex = 4;
            this.lblZipcode.Text = "Zipcode";
            // 
            // tbxOverView
            // 
            this.tbxOverView.BackColor = System.Drawing.Color.White;
            this.tbxOverView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOverView.Location = new System.Drawing.Point(12, 108);
            this.tbxOverView.Multiline = true;
            this.tbxOverView.Name = "tbxOverView";
            this.tbxOverView.ReadOnly = true;
            this.tbxOverView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOverView.Size = new System.Drawing.Size(273, 236);
            this.tbxOverView.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Location = new System.Drawing.Point(654, 172);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(23, 12);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(587, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "주소 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(587, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "우편번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(587, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "전화번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(587, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "홈페이지 :";
            // 
            // linkLblHomePage
            // 
            this.linkLblHomePage.AutoSize = true;
            this.linkLblHomePage.BackColor = System.Drawing.Color.Transparent;
            this.linkLblHomePage.Location = new System.Drawing.Point(654, 204);
            this.linkLblHomePage.Name = "linkLblHomePage";
            this.linkLblHomePage.Size = new System.Drawing.Size(67, 12);
            this.linkLblHomePage.TabIndex = 12;
            this.linkLblHomePage.TabStop = true;
            this.linkLblHomePage.Text = "HomePage";
            this.linkLblHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHomePage_LinkClicked);
            // 
            // pbxPlusImg
            // 
            this.pbxPlusImg.Location = new System.Drawing.Point(345, 108);
            this.pbxPlusImg.Name = "pbxPlusImg";
            this.pbxPlusImg.Size = new System.Drawing.Size(221, 236);
            this.pbxPlusImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlusImg.TabIndex = 14;
            this.pbxPlusImg.TabStop = false;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // plusImageTrackBar
            // 
            this.plusImageTrackBar.AutoSize = false;
            this.plusImageTrackBar.BackColor = System.Drawing.Color.LightGray;
            this.plusImageTrackBar.Location = new System.Drawing.Point(345, 62);
            this.plusImageTrackBar.Name = "plusImageTrackBar";
            this.plusImageTrackBar.Size = new System.Drawing.Size(221, 35);
            this.plusImageTrackBar.TabIndex = 16;
            this.plusImageTrackBar.Scroll += new System.EventHandler(this.plusImageTrackBar_Scroll);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(875, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(898, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(17, 15);
            this.button7.TabIndex = 43;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(5, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 19);
            this.panel2.TabIndex = 44;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // TourListDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.plusImageTrackBar);
            this.Controls.Add(this.pbxPlusImg);
            this.Controls.Add(this.linkLblHomePage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.tbxOverView);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TourListDetail";
            this.Text = "TourListDetail";
            this.Load += new System.EventHandler(this.TourListDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlusImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusImageTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox tbxOverView;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLblHomePage;
        private System.Windows.Forms.PictureBox pbxPlusImg;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TrackBar plusImageTrackBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
    }
}