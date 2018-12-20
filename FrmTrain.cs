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
using Newtonsoft.Json.Linq;

namespace RailoNailo
{
    public partial class FrmTrain : Form
    {
        private Train train;
        private List<Train> traList = new List<Train>();

        int pageNo = 10;
        int pageNum = 1;
        string depPlaceId = "NAT010000"; //출발지 ID
        string arrPlaceId = "NAT011668"; //도착지 ID
        string depPlanTime = "20181201";
        private string serviceKey = "wUgEE5qg4tz1YpeF9csbrTyZ5vsk1AcTEGd%2B7cpaie8Fl8ZCahq3rrl1Z1ZdFdX2xqRRcjzo00AGc%2BgjM3AppA%3D%3D";
        public FrmTrain()
        {
            InitializeComponent();
        }
        private string getjson(int pageNo, int pageNum, string depPlaceId, string arrPlaceId, string depPlanTime)
        {
            
            string serverurl = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo?serviceKey=wUgEE5qg4tz1YpeF9csbrTyZ5vsk1AcTEGd%2B7cpaie8Fl8ZCahq3rrl1Z1ZdFdX2xqRRcjzo00AGc%2BgjM3AppA%3D%3D&pageSize=20&pageNo=" + pageNo + "&startPage=" + pageNum + "&depPlaceId=" + depPlaceId + "&arrPlaceId=" + arrPlaceId + "&depPlandTime=" + depPlanTime + "&_type=json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverurl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string statusCode = response.StatusCode.ToString();
            string json = string.Empty;

            if (statusCode=="OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.UTF8);
                json = sr.ReadToEnd();
                sr.Close();
                stream.Close();
            }
            else
            {
                MessageBox.Show("에러"+statusCode);
            }
            return json;
        }

        private void FrmTrain_Load(object sender, EventArgs e)
        {
            textBox1.Text = getjson(pageNo, pageNum, depPlaceId, arrPlaceId, depPlanTime);

            JObject jobj = JObject.Parse(getjson(pageNo, pageNum, depPlaceId, arrPlaceId, depPlanTime));
            JArray jarr = JArray.Parse(jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item").ToString());
            foreach (JObject item in jarr)
            {
                train = new Train
                {
                    Adultcharge = Convert.ToInt32(item["adultcharge"]),
                    Arrplacename=Convert.ToString(item["arrplacename"]),
                    Arrplandtime=Convert.ToString(item["arrplandtime"]),
                    Depplacename=Convert.ToString(item["depplacename"]),
                    Depplandtime=Convert.ToString(item["depplandtime"]),
                    Traingradename=Convert.ToString(item["traingradename"])
                };
                traList.Add(train);
            }
            foreach (var item in traList)
            {
                textBox2.Text += item.Arrplacename;
            }
        }
    }
}
