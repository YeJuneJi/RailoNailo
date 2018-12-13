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
        private List<JsonCodes> areaList;
        private List<JsonCodes> categoryList;
        private List<JsonCodes> category2List;
        private int numOfRows = 20; //한 페이지 결과 수
        private int pageNo = 1; //한 페이지 번호




        public FormTourInformation()
        {
            InitializeComponent();
            areaList = new List<JsonCodes>();
            categoryList = new List<JsonCodes>();
            category2List = new List<JsonCodes>();
            
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

            DisplayArea("areaCode", areaList, cbxAreas);
            DisplayArea("categoryCode", categoryList, cbxCategory1);

        }

        private void DisplayArea(string operationName, List<JsonCodes> jsonlist, ComboBox cbx)
        {
            JObject jobj = JObject.Parse(GetJson(operationName, string.Empty));
            JArray jarr = JArray.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
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

        private string GetJson(string operationName, string reqParam)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cbxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindNextTokens("areaCode","areaCode", cbxAreas, cbxAreaDetails, areaList);
            //cbxAreaDetails.Items.Clear();

            //string area = string.Empty;
            //foreach (JsonCodes item in areaList)
            //{
            //    if ((cbxAreas.SelectedItem).ToString() == item.Name)
            //    {
            //        area = item.Code;
            //        break;
            //    }
            //}
            //JObject obj = JObject.Parse(GetJson("areaCode", "&areaCode=" + area));
            //tbxResult.Text = obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type.ToString();
            //if (obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type == JTokenType.Array)
            //{
            //    JArray arr = JArray.Parse(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
            //    foreach (JObject item in arr)
            //    {
            //        cbxAreaDetails.Items.Add(item["name"].ToString());
            //    }
            //}
            //else
            //{
            //    cbxAreaDetails.Items.Add(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString());
            //}
        }

        private void cbxCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
             category2List=FindNextTokens("cat1","categoryCode", cbxCategory1, cbxCategory2, categoryList);
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
            List<JsonCodes> jsonList = new List<JsonCodes>();
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
            JObject obj = JObject.Parse(GetJson(operationName, requestMsg + queryString));
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
            //cbxAreaDetails.Items.Clear();

            string area = string.Empty;
            foreach (JsonCodes item in areaList)
            {
                if ((cbxAreas.SelectedItem).ToString() == item.Name)
                {
                    area = item.Code;
                    break;
                }
            }
            JObject obj = JObject.Parse(GetJson("areaCode", "&areaCode=" + area));
            obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type.ToString();
            if (obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").Type == JTokenType.Array)
            {
                JArray arr = JArray.Parse(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
                foreach (JObject item in arr)
                {
                    cbxAreaDetails.Items.Add(item["name"].ToString());
                }
            }
            else
            {
                cbxAreaDetails.Items.Add(obj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString());
            }
        }
    }
}
