﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class Form1 : Form
    {
        PrivateFontCollection privateFonts;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;
        FormWeather fweather;
        Weather weather;
        private readonly double kalvin = Convert.ToDouble(ConfigurationManager.AppSettings.GetValues("Kalvin")[0]);
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "//images//224.png";
            MainImageTry();            
            button1.Image = Properties.Resources.close.ToImage();
            btnTry.Image = Properties.Resources.Retry.ToImage();
            pictureBox3.Image = Properties.Resources.map.ToImage();
            pictureBox2.Image = Properties.Resources.ticket.ToImage();
            pictureBox4.Image = Properties.Resources.time.ToImage();

            privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(Application.StartupPath + "\\Font\\HannaPro.ttf");
            Font font = new Font(privateFonts.Families[0], 12f);
            Font font16 = new Font(privateFonts.Families[0], 16f);
            lbl4.Font = lbl3.Font = lbl2.Font = lbl2.Font = lbl1.Font = lblweather.Font =lblTemp.Font= font;
            btn1.Font = btn2.Font = btnHoneyTip.Font = btn4.Font = font16;
            fweather = new FormWeather();
            weather = fweather.CheckWeather(fweather.getJsonWeather("seoul"));
            if (weather.HowWeather.ToUpper() == "CLOUDS")
            {
                btnWeather.Image = Properties.Resources.Clouds.ToImage();
            }
            else if(weather.HowWeather.ToUpper() == "CLEAR")
            {
                btnWeather.Image = Properties.Resources.Clear.ToImage();
            }
            else if (weather.HowWeather.ToUpper() == "HAZE")
            {
                btnWeather.Image = Properties.Resources.Haze.ToImage();
            }
            else if (weather.HowWeather.ToUpper() == "RAIN")
            {
                btnWeather.Image = Properties.Resources.Rain.ToImage();
            }
            else if (weather.HowWeather.ToUpper() == "MIST")
            {
                btnWeather.Image = Properties.Resources.Mist.ToImage();
            }
            else if (weather.HowWeather.ToUpper() == "FOG")
            {
                btnWeather.Image = Properties.Resources.Fog.ToImage();
            }
            lblTemp.Text = Math.Round(weather.Temp - kalvin, 2).ToString() + " 도(섭씨)";
        }
        
        private void MainImageTry() //메인 배경 랜덤으로 출력
        {
            Random r = new Random();
            this.BackgroundImage = Image.FromFile(Application.StartupPath+"//Images//" + r.Next(1, 7) + ".jpg");
        }

        private void btnHoneyTip_Click(object sender, EventArgs e)
        {
            HoneyTip ht = new HoneyTip();
            ht.Show();
        }        


        private void btnJihyea_Click(object sender, EventArgs e)
        {
            FrmJiHyea fjh = new FrmJiHyea();
            fjh.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            FrmPlan fp = new FrmPlan();
            fp.ShowDialog();
        }

        private void btnTourInfo_Click(object sender, EventArgs e)
        {
            FormTourInformation formTourInformation = new FormTourInformation();
            formTourInformation.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("정말 종료 하시겟습니까 ?","!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.letskorail.com/");
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://info.korail.com/mbs/www/subview.jsp?id=www_020110010000");
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.letskorail.com/ebizcom/cs/guide/guide/guide11.do");
        }       

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }

            base.OnMouseDown(e);
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            MainImageTry();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            FrmTrain ft = new FrmTrain();
            ft.ShowDialog();
        }

        private void btnPlanView_Click(object sender, EventArgs e)
        {
            FrmPlanView fpv = new FrmPlanView();
            fpv.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmJiHyea fjh = new FrmJiHyea();
            fjh.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FrmPlan fp = new FrmPlan();
            fp.ShowDialog();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            FrmPlanView fpv = new FrmPlanView();
            fpv.ShowDialog();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            FormWeather fw = new FormWeather();
            fw.Show();
        }
    }
}
