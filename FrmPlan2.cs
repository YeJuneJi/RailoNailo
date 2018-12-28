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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FrmPlan2 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        string keyword = string.Empty;
        FormTourInformation ftif = new FormTourInformation();
        SearchKeyword searchkeyword;
        List<SearchKeyword> searchkeywordList;
        List<Location> locList;
        Location loc;
        JObject jobject;
        JArray jarray;
        JToken jtoken;
        private DataTable locTable;
        private int totalDataCount = 0; // 전체 데이터 개수
        private int totalPageNo = 0;
        public FrmPlan2()
        {
            InitializeComponent();
            searchkeywordList = new List<SearchKeyword>();
        }
        private void FrmPlan2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath+"\\Images\\happy.jpg");

            locList = new List<Location>();
            tourListView.View = View.LargeIcon;
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString + "AttachDbFilename=" + Application.StartupPath + "\\Railo_DB.mdf";
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

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
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
                jobject = JObject.Parse(json);
                FindTourInformation(jobject);
            }  
        }

        private void FindTourInformation(JObject jobj)
        {
            searchkeywordList.Clear();
            jtoken = jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");
            totalDataCount = Int32.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("totalCount").ToString());
            totalPageNo = (int)(Math.Ceiling((totalDataCount / (double)10)));
            lblPage.Text = string.Format("{0} / {1}", ftif.PageNo, totalPageNo);
            try
            {
                jarray = JArray.Parse(jtoken.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("찾으시는 관광정보가 없습니다!.", "전지혜", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //areaBased.FirstImage에 있는 이미지 주소값을 요청
                HttpWebRequest imgRequest = WebRequest.Create(searchkeyword.FirstImage) as HttpWebRequest;
                //요청한 이미지 주소값에 대한 응답을 가져온다.
                HttpWebResponse imgResponse = imgRequest.GetResponse() as HttpWebResponse;
                //응답된 이미지를 Stream으로 받아온다.
                Stream stream = imgResponse.GetResponseStream();
                //받아온 Stream이미지를 Image타입으로 변환.
                Image img = Image.FromStream(stream);
                //이미지리스트에 이미지를 저장,  키값 = 컨텐츠아이디
                tourimgList.Images.Add(searchkeyword.ContentID, img);
                //타이틀을 텍스트로 리스트뷰아이템에 저장 왜 ? 새로운 리스트뷰 아이템을 만들어 그곳의 이미지 키값과 이미지리스트의 키값과 일치시켜 연결.
                ListViewItem listViewItem = new ListViewItem(searchkeyword.Title);
                //리스트뷰 아이템의 이미지키값 =  컨텐츠 아이디 ->여기서 이미지 리스트와 리스트뷰를 연결시켜준다.
                listViewItem.ImageKey = searchkeyword.ContentID;
                //리스트뷰의 큰이미지 리스트에 이미지 리스트 저장
                tourListView.LargeImageList = tourimgList;
                //리스트뷰에 리스트뷰 아이템을 저장.
                tourListView.Items.Add(listViewItem);

                searchkeywordList.Add(searchkeyword);
                //tbxResult.Text += areaBasedlist.Count + "\r\n";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPlan fp = (FrmPlan)Owner;
            fp.LocString = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
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
            if (ftif.PageNo < totalPageNo)
            {
                ftif.PageNo++;
            }
            else
            {
                MessageBox.Show("마지막 페이지 입니다.");
                return;
            }
            string json = ftif.GetJson("searchKeyword", "&keyword=" + keyword, 10);
            jobject = JObject.Parse(json);
            FindTourInformation(jobject);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tourListView.Clear();
            tourimgList.Images.Clear();
            if (ftif.PageNo > 1)
            {
                ftif.PageNo--;
            }
            else
            {
                MessageBox.Show("첫페이지입니다.");
                return;
            }
            string json = ftif.GetJson("searchKeyword", "&keyword=" + keyword, 10);
            jobject = JObject.Parse(json);
            FindTourInformation(jobject);
        }

        private void tourListView_Click(object sender, EventArgs e)
        {
            TourListDetail tourDetail = new TourListDetail(tourListView.FocusedItem.ImageKey.ToString(), tourListView.LargeImageList.Images[tourListView.FocusedItem.ImageKey.ToString()]);
            tourDetail.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
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
