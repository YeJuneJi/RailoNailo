namespace RailoNailo
{
    partial class FrmPlan
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
            this.rdoDay3 = new System.Windows.Forms.RadioButton();
            this.rdoDay5 = new System.Windows.Forms.RadioButton();
            this.rdoDay7 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sixth = new System.Windows.Forms.PictureBox();
            this.fifth = new System.Windows.Forms.PictureBox();
            this.fourth = new System.Windows.Forms.PictureBox();
            this.third = new System.Windows.Forms.PictureBox();
            this.second = new System.Windows.Forms.PictureBox();
            this.imgCross5 = new System.Windows.Forms.PictureBox();
            this.imgCross4 = new System.Windows.Forms.PictureBox();
            this.imgCross3 = new System.Windows.Forms.PictureBox();
            this.imgCross2 = new System.Windows.Forms.PictureBox();
            this.imgCross1 = new System.Windows.Forms.PictureBox();
            this.first = new System.Windows.Forms.PictureBox();
            this.sixthLbl = new System.Windows.Forms.Label();
            this.fifthLbl = new System.Windows.Forms.Label();
            this.fourthLbl = new System.Windows.Forms.Label();
            this.thirdLbl = new System.Windows.Forms.Label();
            this.secondLbl = new System.Windows.Forms.Label();
            this.firstLbl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sixth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.third)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDay3
            // 
            this.rdoDay3.AutoSize = true;
            this.rdoDay3.Checked = true;
            this.rdoDay3.Location = new System.Drawing.Point(15, 29);
            this.rdoDay3.Name = "rdoDay3";
            this.rdoDay3.Size = new System.Drawing.Size(53, 16);
            this.rdoDay3.TabIndex = 0;
            this.rdoDay3.TabStop = true;
            this.rdoDay3.Text = "3일권";
            this.rdoDay3.UseVisualStyleBackColor = true;
            // 
            // rdoDay5
            // 
            this.rdoDay5.AutoSize = true;
            this.rdoDay5.Location = new System.Drawing.Point(224, 29);
            this.rdoDay5.Name = "rdoDay5";
            this.rdoDay5.Size = new System.Drawing.Size(53, 16);
            this.rdoDay5.TabIndex = 1;
            this.rdoDay5.Text = "5일권";
            this.rdoDay5.UseVisualStyleBackColor = true;
            // 
            // rdoDay7
            // 
            this.rdoDay7.AutoSize = true;
            this.rdoDay7.Location = new System.Drawing.Point(433, 29);
            this.rdoDay7.Name = "rdoDay7";
            this.rdoDay7.Size = new System.Drawing.Size(53, 16);
            this.rdoDay7.TabIndex = 2;
            this.rdoDay7.Text = "7일권";
            this.rdoDay7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDay3);
            this.groupBox1.Controls.Add(this.rdoDay7);
            this.groupBox1.Controls.Add(this.rdoDay5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "티켓 선택";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(15, 62);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 21);
            this.dateStart.TabIndex = 3;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // dateFinal
            // 
            this.dateFinal.Enabled = false;
            this.dateFinal.Location = new System.Drawing.Point(287, 62);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(200, 21);
            this.dateFinal.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateStart);
            this.groupBox2.Controls.Add(this.dateFinal);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "날짜 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "여행 종료일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "여행 시작일";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.firstLbl);
            this.groupBox3.Controls.Add(this.secondLbl);
            this.groupBox3.Controls.Add(this.thirdLbl);
            this.groupBox3.Controls.Add(this.fourthLbl);
            this.groupBox3.Controls.Add(this.fifthLbl);
            this.groupBox3.Controls.Add(this.sixthLbl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.sixth);
            this.groupBox3.Controls.Add(this.fifth);
            this.groupBox3.Controls.Add(this.fourth);
            this.groupBox3.Controls.Add(this.third);
            this.groupBox3.Controls.Add(this.second);
            this.groupBox3.Controls.Add(this.imgCross5);
            this.groupBox3.Controls.Add(this.imgCross4);
            this.groupBox3.Controls.Add(this.imgCross3);
            this.groupBox3.Controls.Add(this.imgCross2);
            this.groupBox3.Controls.Add(this.imgCross1);
            this.groupBox3.Controls.Add(this.first);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 490);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "여행지 선택";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("양재튼튼체B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 16;
            // 
            // sixth
            // 
            this.sixth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sixth.Image = global::RailoNailo.Properties.Resources.iconfinder_Plus_2001887__2_;
            this.sixth.Location = new System.Drawing.Point(13, 287);
            this.sixth.Name = "sixth";
            this.sixth.Size = new System.Drawing.Size(147, 148);
            this.sixth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sixth.TabIndex = 15;
            this.sixth.TabStop = false;
            // 
            // fifth
            // 
            this.fifth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fifth.Image = global::RailoNailo.Properties.Resources.iconfinder_Plus_2001887__2_;
            this.fifth.Location = new System.Drawing.Point(206, 287);
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(147, 148);
            this.fifth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fifth.TabIndex = 14;
            this.fifth.TabStop = false;
            // 
            // fourth
            // 
            this.fourth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fourth.Image = global::RailoNailo.Properties.Resources.iconfinder_Plus_2001887__2_;
            this.fourth.Location = new System.Drawing.Point(398, 287);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(147, 148);
            this.fourth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fourth.TabIndex = 13;
            this.fourth.TabStop = false;
            // 
            // third
            // 
            this.third.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.third.Image = global::RailoNailo.Properties.Resources.iconfinder_Plus_2001887__2_;
            this.third.Location = new System.Drawing.Point(398, 77);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(147, 148);
            this.third.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.third.TabIndex = 12;
            this.third.TabStop = false;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.second.Image = global::RailoNailo.Properties.Resources.iconfinder_Plus_2001887__2_;
            this.second.Location = new System.Drawing.Point(206, 77);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(147, 148);
            this.second.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.second.TabIndex = 11;
            this.second.TabStop = false;
            // 
            // imgCross5
            // 
            this.imgCross5.Image = global::RailoNailo.Properties.Resources.iconfinder_arrow_left_227602;
            this.imgCross5.Location = new System.Drawing.Point(166, 339);
            this.imgCross5.Name = "imgCross5";
            this.imgCross5.Size = new System.Drawing.Size(34, 43);
            this.imgCross5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCross5.TabIndex = 10;
            this.imgCross5.TabStop = false;
            // 
            // imgCross4
            // 
            this.imgCross4.Image = global::RailoNailo.Properties.Resources.iconfinder_arrow_left_227602;
            this.imgCross4.Location = new System.Drawing.Point(359, 339);
            this.imgCross4.Name = "imgCross4";
            this.imgCross4.Size = new System.Drawing.Size(34, 43);
            this.imgCross4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCross4.TabIndex = 9;
            this.imgCross4.TabStop = false;
            // 
            // imgCross3
            // 
            this.imgCross3.Image = global::RailoNailo.Properties.Resources.iconfinder_arrow_down_227604;
            this.imgCross3.Location = new System.Drawing.Point(455, 245);
            this.imgCross3.Name = "imgCross3";
            this.imgCross3.Size = new System.Drawing.Size(34, 41);
            this.imgCross3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCross3.TabIndex = 8;
            this.imgCross3.TabStop = false;
            // 
            // imgCross2
            // 
            this.imgCross2.Image = global::RailoNailo.Properties.Resources.iconfinder_arrow_right_227601;
            this.imgCross2.Location = new System.Drawing.Point(358, 137);
            this.imgCross2.Name = "imgCross2";
            this.imgCross2.Size = new System.Drawing.Size(34, 43);
            this.imgCross2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCross2.TabIndex = 7;
            this.imgCross2.TabStop = false;
            // 
            // imgCross1
            // 
            this.imgCross1.Image = global::RailoNailo.Properties.Resources.iconfinder_arrow_right_227601;
            this.imgCross1.Location = new System.Drawing.Point(166, 137);
            this.imgCross1.Name = "imgCross1";
            this.imgCross1.Size = new System.Drawing.Size(34, 43);
            this.imgCross1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCross1.TabIndex = 6;
            this.imgCross1.TabStop = false;
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.first.Image = global::RailoNailo.Properties.Resources.iconfinder_Plus_2001887__2_;
            this.first.Location = new System.Drawing.Point(15, 77);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(147, 148);
            this.first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.first.TabIndex = 0;
            this.first.TabStop = false;
            // 
            // sixthLbl
            // 
            this.sixthLbl.AutoSize = true;
            this.sixthLbl.Location = new System.Drawing.Point(68, 438);
            this.sixthLbl.Name = "sixthLbl";
            this.sixthLbl.Size = new System.Drawing.Size(0, 12);
            this.sixthLbl.TabIndex = 17;
            // 
            // fifthLbl
            // 
            this.fifthLbl.AutoSize = true;
            this.fifthLbl.Location = new System.Drawing.Point(250, 438);
            this.fifthLbl.Name = "fifthLbl";
            this.fifthLbl.Size = new System.Drawing.Size(0, 12);
            this.fifthLbl.TabIndex = 18;
            // 
            // fourthLbl
            // 
            this.fourthLbl.AutoSize = true;
            this.fourthLbl.Location = new System.Drawing.Point(453, 438);
            this.fourthLbl.Name = "fourthLbl";
            this.fourthLbl.Size = new System.Drawing.Size(0, 12);
            this.fourthLbl.TabIndex = 19;
            // 
            // thirdLbl
            // 
            this.thirdLbl.AutoSize = true;
            this.thirdLbl.Location = new System.Drawing.Point(453, 228);
            this.thirdLbl.Name = "thirdLbl";
            this.thirdLbl.Size = new System.Drawing.Size(0, 12);
            this.thirdLbl.TabIndex = 20;
            // 
            // secondLbl
            // 
            this.secondLbl.AutoSize = true;
            this.secondLbl.Location = new System.Drawing.Point(261, 228);
            this.secondLbl.Name = "secondLbl";
            this.secondLbl.Size = new System.Drawing.Size(0, 12);
            this.secondLbl.TabIndex = 21;
            // 
            // firstLbl
            // 
            this.firstLbl.AutoSize = true;
            this.firstLbl.Location = new System.Drawing.Point(68, 228);
            this.firstLbl.Name = "firstLbl";
            this.firstLbl.Size = new System.Drawing.Size(0, 12);
            this.firstLbl.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 729);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 729);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 784);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPlan";
            this.Text = "FrmPlan";
            this.Load += new System.EventHandler(this.FrmPlan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sixth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.third)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDay3;
        private System.Windows.Forms.RadioButton rdoDay5;
        private System.Windows.Forms.RadioButton rdoDay7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox first;
        private System.Windows.Forms.PictureBox imgCross1;
        private System.Windows.Forms.PictureBox imgCross3;
        private System.Windows.Forms.PictureBox imgCross2;
        private System.Windows.Forms.PictureBox imgCross4;
        private System.Windows.Forms.PictureBox imgCross5;
        private System.Windows.Forms.PictureBox sixth;
        private System.Windows.Forms.PictureBox fifth;
        private System.Windows.Forms.PictureBox fourth;
        private System.Windows.Forms.PictureBox third;
        private System.Windows.Forms.PictureBox second;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label firstLbl;
        private System.Windows.Forms.Label secondLbl;
        private System.Windows.Forms.Label thirdLbl;
        private System.Windows.Forms.Label fourthLbl;
        private System.Windows.Forms.Label fifthLbl;
        private System.Windows.Forms.Label sixthLbl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}