
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FormTourInformation : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private string serviceKey = "Sf8fjXzeJx8CxVqHJ5cDq2WSEO%2B7Gfor9J8ubISBAGIJIidA2L8rVXoAWxCx59Jo4PERKpiKGrqRLF2oMtTy%2Bw%3D%3D"; //서비스 키
        //private string areaCode = string.Empty; //지역코드조회 . 지역코드는 areaCode.json 참조.
        //private string categoryCode = string.Empty; //서비스 분류코드 조회
        //private string areaBasedList = string.Empty;//지역기반 관광정보 조회
        //private string operationName = string.Empty; //오퍼레이션 명

        private JsonCodes code;
        private AreaBased areaBased;
        private List<JsonCodes> areaList;
        private List<JsonCodes> areaDetailList;
        private List<JsonCodes> categoryList;
        private List<JsonCodes> category2List;
        private List<JsonCodes> category3List;
        private List<AreaBased> areaBasedlist;
        //private int numOfRows = 20; //한 페이지 결과 수
        private int totalDataCount = 0; // 전체 데이터 개수
        private int totalPageNo = 0;
        private int pageNo = 1; //한 페이지 번호
        public int PageNo
        {
            get { return this.pageNo;  }
            set { this.pageNo = value; }
        }




        public FormTourInformation()
        {
            InitializeComponent();
            areaList = new List<JsonCodes>();
            areaDetailList = new List<JsonCodes>();
            categoryList = new List<JsonCodes>();
            category2List = new List<JsonCodes>();
            category3List = new List<JsonCodes>();
            areaBasedlist = new List<AreaBased>();
        }

        private void FormTourInformation_Load(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = Properties.Resources.search.ToImage();
            button5.BackgroundImage = Properties.Resources.close.ToImage();
            this.Text = "전국관광정보";
            cbxAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAreaDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAreas.Items.Clear();
            cbxCategory1.Items.Clear();
            tourListView.View = View.LargeIcon;
            btnNext.Enabled = btnPrev.Enabled = false;
            lblInfo.Visible = false;
            DisplayComboBx("areaCode", areaList, cbxAreas);
            DisplayComboBx("categoryCode", categoryList, cbxCategory1);

        }

        private void DisplayComboBx(string operationName, List<JsonCodes> jsonlist, ComboBox cbx)
        {
            JObject jobj = JObject.Parse(GetJson(operationName, string.Empty, 20));
            JArray jarr = JArray.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
            cbx.Items.Add("전체");
            foreach (JObject item in jarr)
            {
                code = new JsonCodes
                {
                    Code = Convert.ToString(item["code"]), //코드
                    Name = Convert.ToString(item["name"]), //코드명
                    Rname = Convert.ToInt32(item["rnum"]) //일련번호
                };
                cbx.Items.Add(code.Name);
                jsonlist.Add(code);
            }
        }

        /// <summary>
        /// API를 JSON문서로 Parsing 하는 메서드
        /// </summary>
        /// <param name="operationName">오퍼레이션 명</param>
        /// <param name="reqParam">추가 응답코드</param>
        /// <param name="numOfRows">한페이지 결과 수</param>
        /// <returns>parsing된 json문서를 string으로 반환</returns>
        internal string GetJson(string operationName, string reqParam, int numOfRows)
        {
            string serverUrl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + operationName + "?ServiceKey=" + serviceKey + "&MobileOS=ETC&MobileApp=TestApp&_type=json&numOfRows=" + numOfRows + "&pageNo=" + pageNo + reqParam;

            HttpWebRequest request = WebRequest.Create(serverUrl) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            string statusCode = response.StatusCode.ToString();
            string json = string.Empty;
            if (statusCode == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
                json = streamReader.ReadToEnd();
                streamReader.Close();
                stream.Close();
            }
            else
            {
                MessageBox.Show("에러발생" + statusCode);
            }
            return json;
        }

        private void cbxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            areaDetailList = FindNextTokens("areaCode", "areaCode", cbxAreas, cbxAreaDetails, areaList);
        }

        private void cbxCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCategory3.Items.Clear();
            category2List = FindNextTokens("cat1", "categoryCode", cbxCategory1, cbxCategory2, categoryList);
        }

        /// <summary>
        /// 하위콤보박스에 동적으로 아이템을 생성해주는 메서드
        /// </summary>
        /// <param name="requestMsg">응답메세지</param>
        /// <param name="operationName">오퍼레이션 명</param>
        /// <param name="parentCbx">상위 콤보박스</param>
        /// <param name="childCbx">하위 콤보박스</param>
        /// <param name="list">상위 콤보박스의 list of JsonCodes</param>
        /// <returns>다음 분류의 객체를 저장하기위한 List를 return</returns>
        private List<JsonCodes> FindNextTokens(string requestMsg, string operationName, ComboBox parentCbx, ComboBox childCbx, List<JsonCodes> list)
        {
            pageNo = 1;
            childCbx.Items.Clear();
            if (parentCbx.SelectedItem.ToString() == "전체")
            {
                childCbx.Items.Add("전체");
                return null;
            }
            List<JsonCodes> jsonList = new List<JsonCodes>();
            jsonList.Clear();
            JsonCodes temp;
            requestMsg = requestMsg.Insert(0, "&").Insert(requestMsg.Length + 1, "=");
            string queryString = string.Empty;
            foreach (JsonCodes lstitem in list)
            {
                if ((parentCbx.SelectedItem).ToString().Trim().Replace(" ", "") == lstitem.Name)
                {
                    queryString = lstitem.Code;
                    break;
                }
            }
            JObject obj = JObject.Parse(GetJson(operationName, requestMsg + queryString, 20));
            if (obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type == JTokenType.Array)
            {
                JArray arr = JArray.Parse(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
                foreach (JObject item in arr)
                {
                    childCbx.Items.Add(item["name"].ToString());
                    temp = new JsonCodes();
                    temp.Code = Convert.ToString(item["code"]);
                    temp.Name = Convert.ToString(item["name"]);
                    temp.Rname = Convert.ToInt32(item["rname"]);
                    jsonList.Add(temp);
                }
            }
            else
            {
                childCbx.Items.Add(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString());
                temp = new JsonCodes();
                temp.Code = obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("code").ToString();
                temp.Name = obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString();
                temp.Rname = Convert.ToInt32(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("rname"));
                jsonList.Add(temp);
            }

            return jsonList;
        }
        private void cbxCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCategory3.Items.Clear();
            category3List.Clear();
            if (cbxCategory2.SelectedItem.ToString() == "전체")
            {
                cbxCategory3.Items.Add("전체");
                return;
            }
            string queryString1 = string.Empty;
            string queryString2 = string.Empty;
            foreach (JsonCodes item in categoryList)
            {
                if ((cbxCategory1.SelectedItem).ToString() == item.Name)
                {
                    queryString1 = item.Code;
                    break;
                }
            }
            foreach (JsonCodes item in category2List)
            {
                if ((cbxCategory2.SelectedItem).ToString() == item.Name)
                {
                    queryString2 = item.Code;
                    break;
                }
            }
            JsonCodes temp;
            JObject obj = JObject.Parse(GetJson("categoryCode", "&cat1=" + queryString1 + "&cat2=" + queryString2, 20));
            obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type.ToString();
            if (obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type == JTokenType.Array)
            {
                JArray arr = JArray.Parse(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
                foreach (JObject item in arr)
                {
                    cbxCategory3.Items.Add(item["name"].ToString());
                    temp = new JsonCodes();
                    temp.Code = Convert.ToString(item["code"]);
                    temp.Name = Convert.ToString(item["name"]);
                    temp.Rname = Convert.ToInt32(item["rname"]);
                    category3List.Add(temp);
                }
            }
            else
            {
                temp = new JsonCodes();
                cbxCategory3.Items.Add(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString());
                temp.Code = obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("code").ToString();
                temp.Name = obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString();
                temp.Rname = Convert.ToInt32(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("rname"));
                category3List.Add(temp);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string requestName1 = string.Empty;
            string requestName2 = string.Empty;
            string requestName3 = string.Empty;
            string requestName4 = string.Empty;
            string requestName5 = string.Empty;
            if (cbxAreas.SelectedIndex == -1 || cbxCategory1.SelectedIndex == -1)
            {
                MessageBox.Show("항목을 선택해 주세요!. ", "전광정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cbxAreas.SelectedItem.ToString() == "전체" && cbxCategory1.SelectedItem.ToString() == "전체")
            {
                JObject jobj = JObject.Parse(GetJson("areaBasedList", string.Empty, 10));
                FindTourInformation(jobj);
            }
            else
            {

                foreach (JsonCodes item in areaList)
                {
                    if (cbxAreas.SelectedItem.ToString() == item.Name)
                    {
                        requestName1 = item.Code;
                        break;
                    }
                }
                requestName2 = GetRequestName(requestName2, areaDetailList, cbxAreaDetails);

                foreach (JsonCodes item in categoryList)
                {
                    if ((cbxCategory1.SelectedItem).ToString() == item.Name)
                    {
                        requestName3 = item.Code;
                        break;
                    }
                }

                requestName4 = GetRequestName(requestName4, category2List, cbxCategory2);
                requestName5 = GetRequestName(requestName5, category3List, cbxCategory3);

                JObject jobj = JObject.Parse(GetJson("areaBasedList", "&areaCode=" + requestName1 + "&sigunguCode=" + requestName2 + "&cat1=" + requestName3 + "&cat2=" + requestName4 + "&cat3=" + requestName5, 10));
                FindTourInformation(jobj);
            }
            lblInfo.Visible = true;
            btnPrev.Enabled = btnNext.Enabled = true;
        }

        /// <summary>
        /// 관광정보를 찾아 이미지로 출력해주는 메서드
        /// </summary>
        /// <param name="jobj">경로가 담긴 jobject 객체</param>
        internal void FindTourInformation(JObject jobj)
        {
            areaBasedlist.Clear();
            JArray jarray;
            JToken jtoken = jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");
            totalDataCount = Int32.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("totalCount").ToString());
            totalPageNo = (int)(Math.Ceiling((totalDataCount / (double)10)));
            lblPage.Text = string.Format("{0} / {1}", pageNo, totalPageNo);
            try
            {
                jarray = JArray.Parse(jtoken.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("찾으시는 관광정보가 없습니다!.", "여행을 떠나자^ㅡ^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tourListView.Clear();
                tourimgList.Images.Clear();
                cbxAreas.SelectedIndex = cbxCategory1.SelectedIndex = 0;
                return;
            }

            tourListView.Clear();
            tourimgList.Images.Clear();
            foreach (JObject item in jarray)
            {
                areaBased = new AreaBased
                {
                    ContentID = item["contentid"].ToString(),
                    Title = Convert.ToString(item["title"]),
                    AreaCode = Convert.ToString(item["areacode"]),
                    SigunguCode = Convert.ToString(item["sigungucode"]),
                    Cat1 = Convert.ToString(item["cat1"]),
                    Cat2 = Convert.ToString(item["cat2"]),
                    Cat3 = Convert.ToString(item["cat3"]),
                    FirstImage = Convert.ToString(item["firstimage"])
                };
                try
                {
                    Uri uri = new Uri(areaBased.FirstImage);
                }
                catch (UriFormatException)
                {
                    areaBased.FirstImage = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                }
                //areaBased.FirstImage에 있는 이미지 주소값을 요청
                HttpWebRequest imgRequest = WebRequest.Create(areaBased.FirstImage) as HttpWebRequest;
                //요청한 이미지 주소값에 대한 응답을 가져온다.
                HttpWebResponse imgResponse = imgRequest.GetResponse() as HttpWebResponse;
                //응답된 이미지를 Stream으로 받아온다.
                Stream stream = imgResponse.GetResponseStream();
                //받아온 Stream이미지를 Image타입으로 변환.
                Image img = Image.FromStream(stream);
                //이미지리스트에 이미지를 저장,  키값 = 컨텐츠아이디
                tourimgList.Images.Add(areaBased.ContentID, img);
                //타이틀을 텍스트로 리스트뷰아이템에 저장 왜 ? 새로운 리스트뷰 아이템을 만들어 그곳의 이미지 키값과 이미지리스트의 키값과 일치시켜 연결.
                ListViewItem listViewItem = new ListViewItem(areaBased.Title);
                //리스트뷰 아이템의 이미지키값 =  컨텐츠 아이디 ->여기서 이미지 리스트와 리스트뷰를 연결시켜준다.
                listViewItem.ImageKey = areaBased.ContentID;
                //리스트뷰의 큰이미지 리스트에 이미지 리스트 저장
                tourListView.LargeImageList = tourimgList;
                //리스트뷰에 리스트뷰 아이템을 저장.
                tourListView.Items.Add(listViewItem);

                areaBasedlist.Add(areaBased);
                //tbxResult.Text += areaBasedlist.Count + "\r\n";
            }
        }

        /// <summary>
        /// 콤보박스에서 선택된 Code를 추출하는 메서드
        /// </summary>
        /// <param name="requestName">추출할 RequestName</param>
        /// <param name="jsonList">RequestName을 추출할 리스트</param>
        /// <param name="comboBox">RequestName을 추출할 콤보박스</param>
        /// <returns>추출된 Code</returns>
        private string GetRequestName(string requestName, List<JsonCodes> jsonList, ComboBox comboBox)
        {
            if (jsonList != null)
            {
                foreach (JsonCodes item in jsonList)
                {
                    if (comboBox.SelectedItem == null)
                    {
                        requestName = string.Empty;
                    }
                    else if ((comboBox.SelectedItem).ToString() == item.Name)
                    {
                        requestName = item.Code;
                        break;
                    }
                }
            }
            return requestName;
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
                btnSearch_Click(null, null);
                return;
            }
            btnSearch_Click(null, null);
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
                btnSearch_Click(null, null);
                return;
            }
            btnSearch_Click(null, null);
        }

        private void tourListView_Click(object sender, EventArgs e)
        {
            TourListDetail tourDetail = new TourListDetail(tourListView.FocusedItem.ImageKey.ToString());
            tourDetail.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
