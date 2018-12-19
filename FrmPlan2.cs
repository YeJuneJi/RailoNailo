using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FrmPlan2 : Form
    {
        FormTourInformation ftif = new FormTourInformation();
        SearchKeyword searchkeyword;
        List<SearchKeyword> searchkeywordList;
        List<Location> locList;
        Location loc;
        private DataTable locTable;
        private int totalDataCount = 0; // 전체 데이터 개수
        private int totalPageNo = 0;
        private int pageNo = 1; //한 페이지 번호
        public FrmPlan2()
        {
            InitializeComponent();
            searchkeywordList = new List<SearchKeyword>();
        }
        private void FrmPlan2_Load(object sender, EventArgs e)
        {
            locList = new List<Location>();
            tourListView.View = View.LargeIcon;
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
            if (e.ColumnIndex == 1)
            {
                string keyword = string.Empty;
                foreach (var item in locList)
                {
                    if (item.LocName == dataGridView1.Rows[(e.RowIndex)].Cells[e.ColumnIndex - 1].Value.ToString())
                    {
                        myWeb.Url = new Uri(item.Link);
                        keyword = item.LocName;
                    }
                }
                
                keyword = HttpUtility.UrlEncode(keyword);
                string json = ftif.GetJson("searchKeyword", "&keyword=" + keyword, 10);
                JObject jobject = JObject.Parse(json);
                searchkeywordList.Clear();
                JArray jarray;
                JToken jtoken = jobject.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");
                totalDataCount = Int32.Parse(jobject.SelectToken("response").SelectToken("body").SelectToken("totalCount").ToString());
                totalPageNo = (int)(Math.Ceiling((totalDataCount / (double)10)));
                lblPage.Text = string.Format("{0} / {1}", pageNo, totalPageNo);
                try
                {
                    jarray = JArray.Parse(jtoken.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show(HttpUtility.UrlDecode(keyword) + "의 정보가 없네요^^.", "전지혜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tourListView.Clear();
                    tourimgList.Images.Clear();
                    return;
                }

                tourListView.Clear();
                tourimgList.Images.Clear();
                foreach (JObject item in jarray)
                {
                    searchkeyword = new SearchKeyword
                    {
                        ContentID = item["contentid"].ToString(),
                        Title = Convert.ToString(item["title"]),
                        FirstImage = Convert.ToString(item["firstimage"])
                    };
                    try
                    {
                        Uri uri = new Uri(searchkeyword.FirstImage);
                    }
                    catch (UriFormatException)
                    {
                        searchkeyword.FirstImage = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                    }
                    HttpWebRequest imgRequest = WebRequest.Create(searchkeyword.FirstImage) as HttpWebRequest;
                    HttpWebResponse imgResponse = imgRequest.GetResponse() as HttpWebResponse;
                    Stream stream = imgResponse.GetResponseStream();
                    Image img = Image.FromStream(stream);
                    tourimgList.Images.Add(searchkeyword.ContentID, img);
                    ListViewItem listViewItem = new ListViewItem(searchkeyword.Title);
                    listViewItem.ImageKey = searchkeyword.ContentID;
                    tourListView.LargeImageList = tourimgList;
                    tourListView.Items.Add(listViewItem);

                    searchkeywordList.Add(searchkeyword);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            tourListView.Clear();
            tourimgList.Images.Clear();
            if (pageNo < totalPageNo)
            {
                pageNo++;
            }
            else
            {
                MessageBox.Show("마지막 페이지 입니다.");
                return;
            }
            dataGridView1_CellClick(null, null);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tourListView.Clear();
            tourimgList.Images.Clear();
            if (pageNo > 1)
            {
                pageNo--;
            }
            else
            {
                MessageBox.Show("첫페이지입니다.");
                return;
            }
            dataGridView1_CellClick(null, null);
        }
    }
}
