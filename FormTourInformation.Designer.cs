namespace RailoNailo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxAreas
            // 
            this.cbxAreas.FormattingEnabled = true;
            this.cbxAreas.Location = new System.Drawing.Point(12, 57);
            this.cbxAreas.Name = "cbxAreas";
            this.cbxAreas.Size = new System.Drawing.Size(121, 20);
            this.cbxAreas.TabIndex = 1;
            this.cbxAreas.SelectedIndexChanged += new System.EventHandler(this.cbxAreas_SelectedIndexChanged);
            // 
            // cbxAreaDetails
            // 
            this.cbxAreaDetails.FormattingEnabled = true;
            this.cbxAreaDetails.Location = new System.Drawing.Point(151, 57);
            this.cbxAreaDetails.Name = "cbxAreaDetails";
            this.cbxAreaDetails.Size = new System.Drawing.Size(121, 20);
            this.cbxAreaDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "지역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(462, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "분류";
            // 
            // cbxCategory1
            // 
            this.cbxCategory1.FormattingEnabled = true;
            this.cbxCategory1.Location = new System.Drawing.Point(464, 57);
            this.cbxCategory1.Name = "cbxCategory1";
            this.cbxCategory1.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory1.TabIndex = 5;
            this.cbxCategory1.SelectedIndexChanged += new System.EventHandler(this.cbxCategory1_SelectedIndexChanged);
            // 
            // cbxCategory2
            // 
            this.cbxCategory2.FormattingEnabled = true;
            this.cbxCategory2.Location = new System.Drawing.Point(591, 57);
            this.cbxCategory2.Name = "cbxCategory2";
            this.cbxCategory2.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory2.TabIndex = 6;
            this.cbxCategory2.SelectedIndexChanged += new System.EventHandler(this.cbxCategory2_SelectedIndexChanged);
            // 
            // cbxCategory3
            // 
            this.cbxCategory3.FormattingEnabled = true;
            this.cbxCategory3.Location = new System.Drawing.Point(718, 57);
            this.cbxCategory3.Name = "cbxCategory3";
            this.cbxCategory3.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory3.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(879, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tourListView
            // 
            this.tourListView.Location = new System.Drawing.Point(12, 116);
            this.tourListView.Name = "tourListView";
            this.tourListView.Size = new System.Drawing.Size(943, 431);
            this.tourListView.TabIndex = 9;
            this.tourListView.UseCompatibleStateImageBehavior = false;
            this.tourListView.Click += new System.EventHandler(this.tourListView_Click);
            // 
            // tourimgList
            // 
            this.tourimgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tourimgList.ImageSize = new System.Drawing.Size(256, 256);
            this.tourimgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.Location = new System.Drawing.Point(254, 557);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(607, 557);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(468, 562);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 12);
            this.lblPage.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(713, 101);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(952, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(17, 15);
            this.button5.TabIndex = 30;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormTourInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 592);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tourListView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxCategory3);
            this.Controls.Add(this.cbxCategory2);
            this.Controls.Add(this.cbxCategory1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button5;
    }
}