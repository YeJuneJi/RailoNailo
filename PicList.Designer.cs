namespace railro.cs
{
    partial class PicList
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicList));
            this.listPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listPic)).BeginInit();
            this.SuspendLayout();
            // 
            // listPic
            // 
            this.listPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPic.Location = new System.Drawing.Point(0, 0);
            this.listPic.Name = "listPic";
            this.listPic.Size = new System.Drawing.Size(832, 430);
            this.listPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.listPic.TabIndex = 33;
            this.listPic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "가평.png");
            this.imageList1.Images.SetKeyName(1, "강릉.png");
            this.imageList1.Images.SetKeyName(2, "경주.png");
            this.imageList1.Images.SetKeyName(3, "광명.png");
            this.imageList1.Images.SetKeyName(4, "광주.png");
            this.imageList1.Images.SetKeyName(5, "광주송정.png");
            this.imageList1.Images.SetKeyName(6, "구미.png");
            this.imageList1.Images.SetKeyName(7, "김천(구미).png");
            this.imageList1.Images.SetKeyName(8, "나주.png");
            this.imageList1.Images.SetKeyName(9, "남원.png");
            this.imageList1.Images.SetKeyName(10, "단양.png");
            this.imageList1.Images.SetKeyName(11, "대구.png");
            this.imageList1.Images.SetKeyName(12, "대전.png");
            this.imageList1.Images.SetKeyName(13, "동대구.png");
            this.imageList1.Images.SetKeyName(14, "동해.png");
            this.imageList1.Images.SetKeyName(15, "마산.png");
            this.imageList1.Images.SetKeyName(16, "목포.png");
            this.imageList1.Images.SetKeyName(17, "민둥산.png");
            this.imageList1.Images.SetKeyName(18, "부산.png");
            this.imageList1.Images.SetKeyName(19, "부전.png");
            this.imageList1.Images.SetKeyName(20, "서울.png");
            this.imageList1.Images.SetKeyName(21, "수원.png");
            this.imageList1.Images.SetKeyName(22, "순천.png");
            this.imageList1.Images.SetKeyName(23, "신경주.png");
            this.imageList1.Images.SetKeyName(24, "안동.png");
            this.imageList1.Images.SetKeyName(25, "여수엑스포.png");
            this.imageList1.Images.SetKeyName(26, "영등포.png");
            this.imageList1.Images.SetKeyName(27, "영월.png");
            this.imageList1.Images.SetKeyName(28, "영전.png");
            this.imageList1.Images.SetKeyName(29, "영주.png");
            this.imageList1.Images.SetKeyName(30, "영천.png");
            this.imageList1.Images.SetKeyName(31, "용산.png");
            this.imageList1.Images.SetKeyName(32, "울산.png");
            this.imageList1.Images.SetKeyName(33, "익산.png");
            this.imageList1.Images.SetKeyName(34, "전주.png");
            this.imageList1.Images.SetKeyName(35, "점촌.png");
            this.imageList1.Images.SetKeyName(36, "정읍.png");
            this.imageList1.Images.SetKeyName(37, "제천.png");
            this.imageList1.Images.SetKeyName(38, "진주.png");
            this.imageList1.Images.SetKeyName(39, "천안.png");
            this.imageList1.Images.SetKeyName(40, "천안아산.png");
            this.imageList1.Images.SetKeyName(41, "청량리.png");
            this.imageList1.Images.SetKeyName(42, "춘양.png");
            this.imageList1.Images.SetKeyName(43, "춘천.png");
            this.imageList1.Images.SetKeyName(44, "충주.png");
            this.imageList1.Images.SetKeyName(45, "태백.png");
            this.imageList1.Images.SetKeyName(46, "평창.png");
            this.imageList1.Images.SetKeyName(47, "포항.png");
            // 
            // PicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listPic);
            this.Name = "PicList";
            this.Size = new System.Drawing.Size(832, 430);
            this.Load += new System.EventHandler(this.PicList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox listPic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
