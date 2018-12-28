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
            this.btnHoneyTip = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btnTry = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnWeather = new System.Windows.Forms.Button();
            this.lblweather = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoneyTip
            // 
            this.btnHoneyTip.FlatAppearance.BorderSize = 0;
            this.btnHoneyTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoneyTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHoneyTip.Location = new System.Drawing.Point(381, 3);
            this.btnHoneyTip.Name = "btnHoneyTip";
            this.btnHoneyTip.Size = new System.Drawing.Size(120, 33);
            this.btnHoneyTip.TabIndex = 1;
            this.btnHoneyTip.Text = "여행꿀팁";
            this.btnHoneyTip.UseVisualStyleBackColor = false;
            this.btnHoneyTip.Click += new System.EventHandler(this.btnHoneyTip_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(205, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(170, 33);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "전국 지역별 혜택";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(507, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(152, 33);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "여행계획짜기";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(25, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(174, 33);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "전국 관광정보";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnTourInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTemp);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnHoneyTip);
            this.panel1.Location = new System.Drawing.Point(-7, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 37);
            this.panel1.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl1.Location = new System.Drawing.Point(256, 74);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 20);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "티켓 발권하기";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl2.Location = new System.Drawing.Point(392, 74);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 20);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "기차노선도";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl3.Location = new System.Drawing.Point(510, 74);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(69, 20);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "열차시간표";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(470, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(352, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(212, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(896, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 15);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.Transparent;
            this.panelMove.Location = new System.Drawing.Point(1, 1);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(866, 19);
            this.panelMove.TabIndex = 14;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.Color.Transparent;
            this.btnTry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTry.FlatAppearance.BorderSize = 0;
            this.btnTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTry.Location = new System.Drawing.Point(873, 3);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(17, 15);
            this.btnTry.TabIndex = 15;
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl4.Location = new System.Drawing.Point(800, 73);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(97, 20);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "내 여행계획보기";
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.BackColor = System.Drawing.Color.Transparent;
            this.btnWeather.FlatAppearance.BorderSize = 0;
            this.btnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeather.Location = new System.Drawing.Point(750, 58);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(44, 41);
            this.btnWeather.TabIndex = 17;
            this.btnWeather.UseVisualStyleBackColor = false;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // lblweather
            // 
            this.lblweather.AutoSize = true;
            this.lblweather.BackColor = System.Drawing.Color.Transparent;
            this.lblweather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblweather.Location = new System.Drawing.Point(586, 35);
            this.lblweather.Name = "lblweather";
            this.lblweather.Size = new System.Drawing.Size(281, 20);
            this.lblweather.TabIndex = 18;
            this.lblweather.Text = "세부적인 날씨를보시려면 이미지를 클릭해 주세요!";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Location = new System.Drawing.Point(727, 3);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 12);
            this.lblTemp.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 583);
            this.Controls.Add(this.lblweather);
            this.Controls.Add(this.btnWeather);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "내일로레일로";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHoneyTip;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Label lblweather;
        private System.Windows.Forms.Label lblTemp;
    }
}

