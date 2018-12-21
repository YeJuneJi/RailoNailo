namespace RailoNailo
{
    partial class FrmPlan2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.myWeb = new System.Windows.Forms.WebBrowser();
            this.tourimgList = new System.Windows.Forms.ImageList(this.components);
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tourListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(261, 553);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(358, 585);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(127, 48);
            this.btnCan.TabIndex = 14;
            this.btnCan.Text = "취소";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(608, 585);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 48);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "적용하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // myWeb
            // 
            this.myWeb.Location = new System.Drawing.Point(297, 26);
            this.myWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWeb.Name = "myWeb";
            this.myWeb.Size = new System.Drawing.Size(349, 553);
            this.myWeb.TabIndex = 16;
            // 
            // tourimgList
            // 
            this.tourimgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tourimgList.ImageSize = new System.Drawing.Size(150, 150);
            this.tourimgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(661, 556);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1007, 556);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(864, 561);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 12);
            this.lblPage.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 19);
            this.panel2.TabIndex = 35;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // tourListView
            // 
            this.tourListView.Location = new System.Drawing.Point(661, 26);
            this.tourListView.Name = "tourListView";
            this.tourListView.Size = new System.Drawing.Size(426, 524);
            this.tourListView.TabIndex = 17;
            this.tourListView.UseCompatibleStateImageBehavior = false;
            this.tourListView.Click += new System.EventHandler(this.tourListView_Click);
            // 
            // FrmPlan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tourListView);
            this.Controls.Add(this.myWeb);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlan2";
            this.Text = "FrmPlan2";
            this.Load += new System.EventHandler(this.FrmPlan2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.WebBrowser myWeb;
        private System.Windows.Forms.ImageList tourimgList;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView tourListView;
    }
}