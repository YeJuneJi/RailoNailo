﻿namespace RailoNailo
{
    partial class FormTourInformation
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
            this.cbxAreas = new System.Windows.Forms.ComboBox();
            this.cbxAreaDetails = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory1 = new System.Windows.Forms.ComboBox();
            this.cbxCategory2 = new System.Windows.Forms.ComboBox();
            this.cbxCategory3 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tourListView = new System.Windows.Forms.ListView();
            this.tourimgList = new System.Windows.Forms.ImageList(this.components);
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxAreas
            // 
            this.cbxAreas.FormattingEnabled = true;
            this.cbxAreas.Location = new System.Drawing.Point(12, 89);
            this.cbxAreas.Name = "cbxAreas";
            this.cbxAreas.Size = new System.Drawing.Size(121, 20);
            this.cbxAreas.TabIndex = 1;
            this.cbxAreas.SelectedIndexChanged += new System.EventHandler(this.cbxAreas_SelectedIndexChanged);
            // 
            // cbxAreaDetails
            // 
            this.cbxAreaDetails.FormattingEnabled = true;
            this.cbxAreaDetails.Location = new System.Drawing.Point(151, 89);
            this.cbxAreaDetails.Name = "cbxAreaDetails";
            this.cbxAreaDetails.Size = new System.Drawing.Size(121, 20);
            this.cbxAreaDetails.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Location = new System.Drawing.Point(12, 63);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 12);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "지역";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Location = new System.Drawing.Point(10, 123);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(29, 12);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "분류";
            // 
            // cbxCategory1
            // 
            this.cbxCategory1.FormattingEnabled = true;
            this.cbxCategory1.Location = new System.Drawing.Point(12, 142);
            this.cbxCategory1.Name = "cbxCategory1";
            this.cbxCategory1.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory1.TabIndex = 5;
            this.cbxCategory1.SelectedIndexChanged += new System.EventHandler(this.cbxCategory1_SelectedIndexChanged);
            // 
            // cbxCategory2
            // 
            this.cbxCategory2.FormattingEnabled = true;
            this.cbxCategory2.Location = new System.Drawing.Point(151, 142);
            this.cbxCategory2.Name = "cbxCategory2";
            this.cbxCategory2.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory2.TabIndex = 6;
            this.cbxCategory2.SelectedIndexChanged += new System.EventHandler(this.cbxCategory2_SelectedIndexChanged);
            // 
            // cbxCategory3
            // 
            this.cbxCategory3.FormattingEnabled = true;
            this.cbxCategory3.Location = new System.Drawing.Point(292, 142);
            this.cbxCategory3.Name = "cbxCategory3";
            this.cbxCategory3.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory3.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(14, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 58);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tourListView
            // 
            this.tourListView.Location = new System.Drawing.Point(464, 116);
            this.tourListView.Name = "tourListView";
            this.tourListView.Size = new System.Drawing.Size(491, 431);
            this.tourListView.TabIndex = 9;
            this.tourListView.UseCompatibleStateImageBehavior = false;
            this.tourListView.Click += new System.EventHandler(this.tourListView_Click);
            // 
            // tourimgList
            // 
            this.tourimgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tourimgList.ImageSize = new System.Drawing.Size(180, 180);
            this.tourimgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(539, 87);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(796, 87);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPage.ForeColor = System.Drawing.Color.Black;
            this.lblPage.Location = new System.Drawing.Point(682, 91);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 19);
            this.lblPage.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(594, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(241, 12);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "세부사항을 보시려면 그림을 클릭해 주세요!";
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Location = new System.Drawing.Point(1, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(945, 19);
            this.panelMove.TabIndex = 31;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(950, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 15);
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(213, 32);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "전국관광정보";
            // 
            // FormTourInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 592);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tourListView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxCategory3);
            this.Controls.Add(this.cbxCategory2);
            this.Controls.Add(this.cbxCategory1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cbxAreaDetails);
            this.Controls.Add(this.cbxAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTourInformation";
            this.Text = "FormTourInformation";
            this.Load += new System.EventHandler(this.FormTourInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxAreas;
        private System.Windows.Forms.ComboBox cbxAreaDetails;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory1;
        private System.Windows.Forms.ComboBox cbxCategory2;
        private System.Windows.Forms.ComboBox cbxCategory3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView tourListView;
        private System.Windows.Forms.ImageList tourimgList;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
    }
}