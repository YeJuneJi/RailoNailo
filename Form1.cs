using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MainImageTry();
            //폰트변경
            //PrivateFontCollection privateFonts = new PrivateFontCollection();      
            //privateFonts.AddFontFile( "한나체!.ttf" );
            //Font font = new Font(privateFonts.Families[0], 24f);
            //btn1.Font = btn2.Font= btnHoneyTip.Font= btn4.Font=font;

        }

        private void MainImageTry() //메인 배경 랜덤으로 출력
        {
            Random r = new Random();
            this.BackgroundImage = Image.FromFile(@"C:\Railo\mainForm\" + r.Next(1, 7) + ".jpg");
        }

        private void btnHoneyTip_Click(object sender, EventArgs e)
        {
            HoneyTip ht = new HoneyTip();
            ht.Show();
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

        
    }
}
