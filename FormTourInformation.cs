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
        private string areaCode = string.Empty; //지역코드조회 . 지역코드는 areaCode.json 참조.
        private string categoryCode = string.Empty; //서비스 분류코드 조회
        private string areaBasedList = string.Empty;//지역기반 관광정보 조회
        private string operationName = string.Empty; //오퍼레이션 명

        private int numOfRows = 17; //한 페이지 결과 수
        private int pageNo = 1; //한 페이지 번호
        public FormTourInformation()
        {
            InitializeComponent();
        }

        private void FormTourInformation_Load(object sender, EventArgs e)
        {
            this.Text = "전국관광정보";
            cbxAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAreas.Items.Clear();

            JObject jobj = JObject.Parse(GetJson("areaCode", string.Empty));
            JArray arr = JArray.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());

            foreach (var item in arr)
            {
                cbxAreas.Items.Add(item["name"].ToString());
            }

            //GetJson("areaCode", "&areaCode=1");
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
                tbxResult.Text = json = streamReader.ReadToEnd();//.Replace("<b>", "").Replace("</b>", "");
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
    }
}
