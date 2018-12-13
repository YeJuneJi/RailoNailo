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
        private string categoryCode = string.Empty; //서비스 분류코드 조회
        private string areaBasedList = string.Empty;//지역기반 관광정보 조회
        private string operationName = string.Empty; //오퍼레이션 명

        JsonCodes code;
        
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
            cbxAreaDetails.Items.Clear();
            
            int area = 0;
            foreach (JsonCodes item in areaList)
            {
                if ((cbxAreas.SelectedItem).ToString() == item.Name)
                {
                    area = Convert.ToInt32(item.Code);
                    break;
                }
            }
            JObject areaObj = JObject.Parse(GetJson("areaCode", "&areaCode=" + area));
            if (area != 8)
            {
                JArray areaArr = JArray.Parse(areaObj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
                foreach (JObject item in areaArr)
                {
                    cbxAreaDetails.Items.Add(item["name"].ToString());
                }
            }
            else
            {
                cbxAreaDetails.Items.Add(areaObj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").SelectToken("name").ToString());
            }
        }

        private void cbxCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbxCategory2.Items.Clear();
            string category = string.Empty;
            foreach (JsonCodes categoryitem in categoryList)
            {
                if ((cbxCategory1.SelectedItem).ToString() == categoryitem.Name)
                {
                    category = categoryitem.Code;
                    break;
                }
                JObject categoryObj = JObject.Parse(GetJson("categoryCode", "&cat1=" + category));
                JArray categoryArr = JArray.Parse(categoryObj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
                foreach (JObject item in categoryArr)
                {
                    cbxCategory2.Items.Add(item["name"].ToString());
                }
            }
        }
    }
}
