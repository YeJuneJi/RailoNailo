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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(34, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Location = new System.Drawing.Point(99, 107);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(52, 12);
            this.lblAddr.TabIndex = 2;
            this.lblAddr.Text = "Address";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(99, 142);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(51, 12);
            this.lblZipcode.TabIndex = 4;
            this.lblZipcode.Text = "Zipcode";
            // 
            // tbxOverView
            // 
            this.tbxOverView.Location = new System.Drawing.Point(12, 288);
            this.tbxOverView.Multiline = true;
            this.tbxOverView.Name = "tbxOverView";
            this.tbxOverView.ReadOnly = true;
            this.tbxOverView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOverView.Size = new System.Drawing.Size(794, 189);
            this.tbxOverView.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(99, 177);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(23, 12);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "주소 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "우편번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "전화번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "홈페이지 :";
            // 
            // linkLblHomePage
            // 
            this.linkLblHomePage.AutoSize = true;
            this.linkLblHomePage.Location = new System.Drawing.Point(99, 205);
            this.linkLblHomePage.Name = "linkLblHomePage";
            this.linkLblHomePage.Size = new System.Drawing.Size(67, 12);
            this.linkLblHomePage.TabIndex = 12;
            this.linkLblHomePage.TabStop = true;
            this.linkLblHomePage.Text = "HomePage";
            this.linkLblHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHomePage_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "개요";
            // 
            // TourListDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.label5);
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
            this.Name = "TourListDetail";
            this.Text = "TourListDetail";
            this.Load += new System.EventHandler(this.TourListDetail_Load);
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
        private System.Windows.Forms.Label label5;
    }
}