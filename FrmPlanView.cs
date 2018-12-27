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
    public partial class FrmPlanView : Form
    {
        PrivateFontCollection privateFonts;
        Bitmap bm;
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
            btnSave.BackgroundImage= Image.FromFile(Application.StartupPath + "\\Images\\Save.png");

            btnSave.BackColor = Color.MistyRose;
            privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(Application.StartupPath + "\\Font\\HannaPro.ttf");
            Font font16 = new Font(privateFonts.Families[0], 15f);

            //FirstLbl.Parent = First2;
            //SecondLbl.Parent = Second2;
            //ThirdLbl.Parent = Third2;
            //FourthLbl.Parent = Fourth2;
            //FifthLbl.Parent = Fifth2;
            //SixthLbl.Parent = Sixth2;

            for (int i = 0; i < 3; i++)
            {
                foreach (Control item in Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.Label")
                    {
                        var pos = this.PointToScreen(item.Location);
                        item.Font = font16;
                        foreach (Control item2 in Controls)
                        {
                            if (item2.GetType().ToString() == "System.Windows.Forms.PictureBox")
                            {
                                if (item.Name.Contains(item2.Name.Substring(0, 3)))
                                {
                                    pos = item2.PointToClient(pos);

                                    item.Parent = item2;
                                    item.BackColor = Color.Transparent;
                                    item.Location = pos;
                                    break;
                                }
                            }
                        }
                    }
                } 
            }

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
                    label3.Text = dr["date"].ToString();
                    if (dr["loc1"].ToString() != "NULL")
                    {
                        FirstLbl.Text = dr["loc1"].ToString();
                        First.Image = ImageAccess(FirstLbl.Text);
                        if (dr["loc2"].ToString() != "NULL")
                        {
                            SecondLbl.Text = dr["loc2"].ToString();
                            Second.Image = ImageAccess(SecondLbl.Text);
                            if (dr["loc3"].ToString() != "NULL")
                            {
                                ThirdLbl.Text = dr["loc3"].ToString();
                                Third.Image = ImageAccess(ThirdLbl.Text);

                                if (dr["loc4"].ToString() != "NULL")
                                {
                                    FourthLbl.Text = dr["loc4"].ToString();
                                    Fourth.Image = ImageAccess(FourthLbl.Text);
                                    if (dr["loc5"].ToString() != "NULL")
                                    {
                                        FifthLbl.Text = dr["loc5"].ToString();
                                        Fifth.Image = ImageAccess(FifthLbl.Text);
                                        if (dr["loc6"].ToString() != "NULL")
                                        {
                                            SixthLbl.Text = dr["loc6"].ToString();
                                            Sixth.Image = ImageAccess(SixthLbl.Text);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
                dr.Close();
                con.Close();
                for (int i = 0; i < 3; i++)
                {
                    foreach (Control item in Controls)
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.Label")
                        {
                            if (item.Text == null)
                            {
                                Controls.Remove(item);
                            }
                        }
                        if (item.GetType().ToString() == "System.Windows.Forms.PictureBox")
                        {
                            if (((PictureBox)item).Image == null)
                            {
                                Controls.Remove(item);
                            }
                        }
                    } 
                }
            }

        }

        private Image ImageAccess(string text)
        {
            Image returnImage;
            try
            {
                returnImage = Image.FromFile(Application.StartupPath + "\\Images\\" + text + ".png");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            bm = new Bitmap(ClientSize.Width, ClientSize.Height);
            var grapics=Graphics.FromImage(bm);
            

            saveFileDialog1.Filter = "JPEG File(*jpg)|*.jpg|Bitmap File(*.bmp)|*.bmp|PNG File(*.png)|*.png";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (Control item in Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.Button")
                    {
                        Controls.Remove(item);
                    }
                }
                grapics.CopyFromScreen(new Point(this.Location.X, this.Location.Y), new Point(0, 0), this.Size);
                bm.Save(saveFileDialog1.FileName);
                this.Close();
            }
        }
    }
}
