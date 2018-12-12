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
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.cbxAreas = new System.Windows.Forms.ComboBox();
            this.cbxAreaDetails = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategory1 = new System.Windows.Forms.ComboBox();
            this.cbxCategory2 = new System.Windows.Forms.ComboBox();
            this.cbxCategory3 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(12, 311);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(503, 127);
            this.tbxResult.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "지역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "분류";
            // 
            // cbxCategory1
            // 
            this.cbxCategory1.FormattingEnabled = true;
            this.cbxCategory1.Location = new System.Drawing.Point(327, 57);
            this.cbxCategory1.Name = "cbxCategory1";
            this.cbxCategory1.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory1.TabIndex = 5;
            // 
            // cbxCategory2
            // 
            this.cbxCategory2.FormattingEnabled = true;
            this.cbxCategory2.Location = new System.Drawing.Point(454, 57);
            this.cbxCategory2.Name = "cbxCategory2";
            this.cbxCategory2.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory2.TabIndex = 6;
            this.cbxCategory2.SelectedIndexChanged += new System.EventHandler(this.cbxCategory2_SelectedIndexChanged);
            // 
            // cbxCategory3
            // 
            this.cbxCategory3.FormattingEnabled = true;
            this.cbxCategory3.Location = new System.Drawing.Point(581, 57);
            this.cbxCategory3.Name = "cbxCategory3";
            this.cbxCategory3.Size = new System.Drawing.Size(121, 20);
            this.cbxCategory3.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(742, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormTourInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxCategory3);
            this.Controls.Add(this.cbxCategory2);
            this.Controls.Add(this.cbxCategory1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAreaDetails);
            this.Controls.Add(this.cbxAreas);
            this.Controls.Add(this.tbxResult);
            this.Name = "FormTourInformation";
            this.Text = "FormTourInformation";
            this.Load += new System.EventHandler(this.FormTourInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.ComboBox cbxAreas;
        private System.Windows.Forms.ComboBox cbxAreaDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategory1;
        private System.Windows.Forms.ComboBox cbxCategory2;
        private System.Windows.Forms.ComboBox cbxCategory3;
        private System.Windows.Forms.Button btnSearch;
    }
}