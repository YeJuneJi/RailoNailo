using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FrmPlan : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private string locString;

        public string LocString { get => locString; set => locString = value; }

        public FrmPlan()
        {
            InitializeComponent();
            foreach (Control item in groupBox3.Controls)
            {
                if (item.GetType().ToString()=="System.Windows.Forms.PictureBox" && !(item.Name.Contains("Cross")))
                {
                    ((PictureBox)item).ImageLocation = Application.StartupPath + "\\Images\\plus.png";
                }
            }
        }

        private void rdoDay3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDay7.Checked)
            {
                dateFinal.Value = dateStart.Value.AddDays(7);
            }
            else if (rdoDay5.Checked)
            {
                dateFinal.Value = dateStart.Value.AddDays(5);
            }
            else
            {
                dateFinal.Value = dateStart.Value.AddDays(3);
            }
            label3.Text = dateStart.Value.ToShortDateString() + " 부터 " + dateFinal.Value.ToShortDateString();
        }
        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateStart.Value<DateTime.Now)
            {
                MessageBox.Show("시작 일은 오늘보다 전 날 일수 없습니다.");
                dateStart.Value = DateTime.Now;
                return;
            }
            else
            {
                if (rdoDay7.Checked)
                {
                    dateFinal.Value = dateStart.Value.AddDays(7);
                }
                else if (rdoDay5.Checked)
                {
                    dateFinal.Value = dateStart.Value.AddDays(5);
                }
                else
                {
                    dateFinal.Value = dateStart.Value.AddDays(3);
                }
                label3.Text = dateStart.Value.ToShortDateString() + " 부터 " + dateFinal.Value.ToShortDateString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPlan_Load(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.close.ToImage();
            foreach (Control item in groupBox3.Controls)
            {
                if (item.GetType().ToString()=="System.Windows.Forms.PictureBox"&&!(item.Name.Contains("Cross")))
                {
                    item.Click += PictureBoxClick;
                }
            }
            imgCross1.Image = Image.FromFile(Application.StartupPath + "\\Images\\right.png");
            imgCross2.Image = Image.FromFile(Application.StartupPath + "\\Images\\right.png");
            imgCross3.Image = Image.FromFile(Application.StartupPath + "\\Images\\down.png");
            imgCross4.Image = Image.FromFile(Application.StartupPath + "\\Images\\left.png");
            imgCross5.Image = Image.FromFile(Application.StartupPath + "\\Images\\left.png");
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images\\planBack.jpg");
            
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            FrmPlan2 fp2 = new FrmPlan2();
            fp2.Owner = this;
            fp2.ShowDialog();

            if (!string.IsNullOrEmpty(locString))
            {
                ((PictureBox)sender).SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath+"\\Images\\" + locString + ".png");
                    ((PictureBox)sender).Image.Tag = LocString;
                }
                catch (Exception)
                {
                    ((PictureBox)sender).Image = Image.FromFile(Application.StartupPath + "\\Images\\noImage.jpg");
                    ((PictureBox)sender).Image.Tag = LocString;
                }
                foreach (Control item in groupBox3.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.Label" && item.Name.Contains(((PictureBox)sender).Name))
                    {
                        item.Tag = LocString;
                        item.Text = LocString;
                        break;
                    }
                } 
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label3.Text))
            {
                MessageBox.Show("날짜를 선택하셔야 됩니다.");
            }
            else
            {
                string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString + "AttachDbFilename=" + Application.StartupPath + "\\Railo_DB.mdf";
                string[] planArr = new string[6];
                int count = 0;
                foreach (Control item in groupBox3.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.Label" && item.Name != "label3")
                    {
                        if (!string.IsNullOrEmpty(item.Text))
                        {
                            planArr[count] = item.Text;
                            count++;
                        }
                    }
                }
                for (int i = 0; i < planArr.Length; i++)
                {
                    if (planArr[i] == null)
                    {
                        planArr[i] = "NULL";
                    }
                }
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertPlan";
                    cmd.Parameters.AddWithValue("loc1", planArr[0]);
                    cmd.Parameters.AddWithValue("loc2", planArr[1]);
                    cmd.Parameters.AddWithValue("loc3", planArr[2]);
                    cmd.Parameters.AddWithValue("loc4", planArr[3]);
                    cmd.Parameters.AddWithValue("loc5", planArr[4]);
                    cmd.Parameters.AddWithValue("loc6", planArr[5]);
                    cmd.Parameters.AddWithValue("date", label3.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("저장 성공!");
                    }
                    else
                    {
                        MessageBox.Show("저장 실패");
                    }
                    con.Close();
                }
                this.Close();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
