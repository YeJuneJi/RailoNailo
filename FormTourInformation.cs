using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FormTourInformation : Form
    {
        private string serviceKey = "Sf8fjXzeJx8CxVqHJ5cDq2WSEO%2B7Gfor9J8ubISBAGIJIidA2L8rVXoAWxCx59Jo4PERKpiKGrqRLF2oMtTy%2Bw%3D%3D"; //서비스 키
        //private string areaCode = string.Empty; //지역코드조회 . 지역코드는 areaCode.json 참조.
        //private string categoryCode = string.Empty; //서비스 분류코드 조회
        //private string areaBasedList = string.Empty;//지역기반 관광정보 조회
        //private string operationName = string.Empty; //오퍼레이션 명

        private JsonCodes code;
        private areaBasedList areaBased;
        private List<JsonCodes> areaList;
        private List<JsonCodes> areaDetailList;
        private List<JsonCodes> categoryList;
        private List<JsonCodes> category2List;
        private List<JsonCodes> category3List;
        private List<areaBasedList> areaBasedlist;
        private int numOfRows = 20; //한 페이지 결과 수
        private int pageNo = 1; //한 페이지 번호




        public FormTourInformation()
        {
            InitializeComponent();
            areaList = new List<JsonCodes>();
            areaDetailList = new List<JsonCodes>();
            categoryList = new List<JsonCodes>();
            category2List = new List<JsonCodes>();
            category3List = new List<JsonCodes>();
            areaBasedlist = new List<areaBasedList>();
            
        }

        private void FormTourInformation_Load(object sender, EventArgs e)
        {
            this.Text = "전국관광정보";
            cbxAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAreaDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAreas.Items.Clear();
            cbxCategory1.Items.Clear();
            tourListView.View = View.LargeIcon;

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

        private string GetJson(string operationName, string reqParam, int numOfRows)
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
            areaDetailList = FindNextTokens("areaCode","areaCode", cbxAreas, cbxAreaDetails, areaList);
        }

        private void cbxCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCategory3.Items.Clear();
            category2List = FindNextTokens("cat1","categoryCode", cbxCategory1, cbxCategory2, categoryList);
        }

        /// <summary>
        /// 하위콤보박스에 동적으로 아이템을 생성해주는 메서드
        /// </summary>
        /// <param name="requestMsg">응답메세지</param>
        /// <param name="operationName">오퍼레이션 명</param>
        /// <param name="parentCbx">상위 콤보박스</param>
        /// <param name="childCbx">하위 콤보박스</param>
        /// <param name="list">상위 콤보박스의 list of JsonCodes</param>
        private List<JsonCodes> FindNextTokens(string requestMsg,string operationName, ComboBox parentCbx, ComboBox childCbx, List<JsonCodes> list)
        {
            childCbx.Items.Clear();
            if (parentCbx.SelectedItem.ToString() == "전체")
            {
                childCbx.Items.Add("전체");
                return null;
            }
            List<JsonCodes> jsonList = new List<JsonCodes>();
            jsonList.Clear();
            JsonCodes temp;
            requestMsg = requestMsg.Insert(0, "&").Insert(requestMsg.Length+1, "=");
            string queryString = string.Empty;
            foreach (JsonCodes lstitem in list)
            {
                if ((parentCbx.SelectedItem).ToString().Trim().Replace(" ","") == lstitem.Name)
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
            JObject obj = JObject.Parse(GetJson("categoryCode", "&cat1=" + queryString1+"&cat2=" + queryString2, 20));
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
            if (cbxAreas.SelectedItem.ToString() == "전체" && cbxCategory1.SelectedItem.ToString() == "전체")
            {
                //string serverUri = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaBasedList?ServiceKey=" + serviceKey + "&MobileOS=ETC&MobileApp=AppTest&_type=json&numOfRows=" + numOfRows + "&pageNo=" + pageNo;
                JObject jobj = JObject.Parse(GetJson("areaBasedList", string.Empty, 10));
                JArray jarray = JArray.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
                tourListView.Clear();
                tourimgList.Images.Clear();
                foreach (JObject item in jarray)
                {
                    areaBased = new areaBasedList
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
                    
                    HttpWebRequest imgRequest = WebRequest.Create(areaBased.FirstImage) as HttpWebRequest;
                    HttpWebResponse imgResponse = imgRequest.GetResponse() as HttpWebResponse;
                    Stream stream = imgResponse.GetResponseStream();
                    Image img = Image.FromStream(stream);
                    tourListView.LargeImageList = tourimgList;
                    tourimgList.Images.Add(areaBased.ContentID, img);
                    ListViewItem listViewItem = new ListViewItem(areaBased.Title);
                    listViewItem.ImageKey = areaBased.ContentID;
                    tourListView.Items.Add(listViewItem);
                    
                    tbxResult.Text += areaBased.ContentID+"\r\n";
                    areaBasedlist.Add(areaBased);
                }
            }
        }
    }
}
