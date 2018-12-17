namespace RailoNailo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJihyea = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJihyea
            // 
            this.btnJihyea.Location = new System.Drawing.Point(662, 37);
            this.btnJihyea.Name = "btnJihyea";
            this.btnJihyea.Size = new System.Drawing.Size(142, 91);
            this.btnJihyea.TabIndex = 0;
            this.btnJihyea.Text = "button1";
            this.btnJihyea.UseVisualStyleBackColor = true;
            this.btnJihyea.Click += new System.EventHandler(this.btnJihyea_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Location = new System.Drawing.Point(662, 167);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(142, 91);
            this.btnPlan.TabIndex = 1;
            this.btnPlan.Text = "button2";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.btnJihyea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJihyea;
        private System.Windows.Forms.Button btnPlan;
    }
}

