using System;
using System.Collections;
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
    public partial class FrmPlan2 : Form
    {
        
        List<Location> locList;
        Location loc;
        private DataTable locTable;
        public FrmPlan2()
        {
            InitializeComponent();
        }
        private void FrmPlan2_Load(object sender, EventArgs e)
        {
            locList = new List<Location>();

            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            locTable = new DataTable();
            locTable.Columns.Add("역 이름");
            
            using (SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectLoc";

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    loc = new Location();

                    DataRow row = locTable.NewRow();
                    row["역 이름"] =loc.LocName =dr["locName"].ToString();
                    locTable.Rows.Add(row);
                    loc.Link = dr["locLink"].ToString();

                    locList.Add(loc);
                }
                dr.Close();
                con.Close();
            }
            dataGridView1.DataSource = locTable;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "관광 정보";
            btn.Name = "Button";
            btn.Text = "자세히보기";
            btn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btn);



            foreach (Control item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Button" && item.Name.Length >= 7)
                {
                    item.Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                foreach (var item in locList)
                {
                    if (item.LocName== dataGridView1.Rows[(e.RowIndex)].Cells[e.ColumnIndex - 1].Value.ToString())
                    {
                        myWeb.Url = new Uri(item.Link);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPlan fp = (FrmPlan)Owner;
            fp.LocString = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            //역 이름
            MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            this.Close();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            FrmPlan fp = (FrmPlan)Owner;
            fp.LocString = null;
            this.Close();
        }
    }
}
