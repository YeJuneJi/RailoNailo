using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FrmPlanView : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public FrmPlanView()
        {
            InitializeComponent();
        }

        private void FrmPlanView_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images\\ViewBack.jpg");
            button7.BackgroundImage = Properties.Resources.close.ToImage();
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString + "AttachDbFilename=" + Application.StartupPath + "\\Railo_DB.mdf";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectPlan";

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label3.Text= dr["date"].ToString();
                    if (dr["loc1"].ToString()!="NULL")
                    {
                        firstLbl.Text = dr["loc1"].ToString();
                        first.Image=ImageAccess(firstLbl.Text);
                        if (dr["loc2"].ToString() != "NULL")
                        {
                            secondLbl.Text = dr["loc2"].ToString();
                            second.Image = ImageAccess(secondLbl.Text);
                            if (dr["loc3"].ToString() != "NULL")
                            {
                                thirdLbl.Text = dr["loc3"].ToString();
                                third.Image = ImageAccess(thirdLbl.Text);
                                if (dr["loc4"].ToString() != "NULL")
                                {
                                    fourthLbl.Text = dr["loc4"].ToString();
                                    fourth.Image = ImageAccess(fourthLbl.Text);
                                    if (dr["loc5"].ToString() != "NULL")
                                    {
                                        fifthLbl.Text = dr["loc5"].ToString();
                                        fifth.Image = ImageAccess(fifthLbl.Text);
                                        if (dr["loc6"].ToString() != "NULL")
                                        {
                                            sixthLbl.Text = dr["loc6"].ToString();
                                            sixth.Image = ImageAccess(sixthLbl.Text);
                                        }
                                        else
                                        {
                                            imgCross5.Image = null;
                                        }
                                    }
                                    else
                                    {
                                        imgCross5.Image = imgCross4.Image = null;
                                    }
                                }
                                else
                                {
                                    imgCross5.Image = imgCross4.Image = imgCross3.Image = null;
                                }
                            }
                            else
                            {
                                imgCross5.Image = imgCross4.Image = imgCross3.Image = imgCross2.Image = null;
                            }
                        }
                    }
                }
                dr.Close();
                con.Close();
            }
        }

        private Image ImageAccess(string text)
        {
            Image returnImage;
            try
            {
                returnImage = Image.FromFile(Application.StartupPath+"\\Images\\" + text + ".png");
            }
            catch (Exception)
            {
                returnImage = Image.FromFile(Application.StartupPath + "\\Images\\" + "noImage.jpg");
            }
            return returnImage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
