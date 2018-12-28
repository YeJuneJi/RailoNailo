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
    public partial class HoneyTipBlogSave : Form
    {
       
        
        List<string> bs = new List<string>();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public HoneyTipBlogSave(List<string> blogSave, List<string> blogSaveLink)
        {            
            bs = blogSaveLink;
            InitializeComponent();
            dataGridView1.Columns.Add("", "블로그 이름");
            foreach (var item in blogSave)
            {                
                dataGridView1.Rows.Add(item);
            }    
        }

        public HoneyTipBlogSave()
        {
            
        }

        private void HoneyTipBlogSave_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "//Images//1.jpg");
            btnClose.Image = Properties.Resources.close.ToImage();

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(Application.StartupPath + "\\Font\\HannaPro.ttf");
            Font font = new Font(privateFonts.Families[0], 14f);
            label1.Font = font;
            btnClose.Image = Properties.Resources.close.ToImage();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               
                System.Diagnostics.Process.Start(bs[e.RowIndex].ToString());
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("제목을 클릭해주세요 ");
            }            
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
    }
}
