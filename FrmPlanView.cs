using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FrmPlanView : Form
    {
        public FrmPlanView()
        {
            InitializeComponent();
        }

        private void FrmPlanView_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
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
                returnImage = Image.FromFile(@"C:\Users\gd12\source\repos\railro.cs\railro.cs\Images\" + text + ".png");
            }
            catch (Exception)
            {
                returnImage = Image.FromFile(@"C:\Users\gd12\source\repos\railro.cs\railro.cs\Images\noImage.jpg");
            }
            return returnImage;
        }
    }
}
