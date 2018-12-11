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
using System.Web;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class HoneyTip : Form
    {
        public HoneyTip()
        {
            InitializeComponent();
        }

        private void HoneyTip_Load(object sender, EventArgs e)
        {
            string honeyTipTitle = HttpUtility.UrlEncode("내일로");
            string serverUrl = "https://openapi.naver.com/v1/search/blog.json?query=" + honeyTipTitle + "&display=9";

            JObject honeyTipData = JObject.Parse(JsonConnetInfo(serverUrl));//제이슨 연결후 데이터 가져옴 가져온데이터 JObject타입으로 캐스팅

            var honeyTipArray = JArray.Parse(honeyTipData["items"].ToString());

            string[] a = new string[27]; //제목, 블로그 이름(+9), 링크 (+18)
            
            for (int i = 0; i < honeyTipArray.Count; i++)
            {
                a[i] = honeyTipArray[i]["title"].ToString();
                if (honeyTipArray[i]["bloggername"].ToString().Length>15)
                {
                    a[i + 9] = honeyTipArray[i]["bloggername"].ToString().Remove(14, honeyTipArray[i]["bloggername"].ToString().Length-14);
                }
                else
                {
                    a[i + 9] = honeyTipArray[i]["bloggername"].ToString();
                }                
                a[i+18] = honeyTipArray[i]["link"].ToString().Replace("?Redirect=Log&amp;logNo=", "/");
            }

            btnImg1.Text = a[0];
            btnImg2.Text = a[1];
            btnImg3.Text = a[2];
            btnImg4.Text = a[3];
            btnImg5.Text = a[4];
            btnImg6.Text = a[5];
            btnImg7.Text = a[6];
            btnImg8.Text = a[7];
            btnImg9.Text = a[8];

            lbl1.Text = a[9];
            lbl2.Text = a[10];
            lbl3.Text = a[11];
            lbl4.Text = a[12];
            lbl5.Text = a[13];
            lbl6.Text = a[14];
            lbl7.Text = a[15];
            lbl8.Text = a[16];
            lbl9.Text = a[17];

            System.Diagnostics.Process.Start(a[20]);
        }

        private string JsonConnetInfo(string serverUrl)
        {
            string apiId = "rIlnNuhQFn82_dwFodfG";
            string apiPw = "sZCNlww0tF";
            var request = (HttpWebRequest)WebRequest.Create(serverUrl);
            request.Headers.Add("X-Naver-Client-Id", apiId);
            request.Headers.Add("X-Naver-Client-Secret", apiPw);

            var respone = (HttpWebResponse)request.GetResponse();
            
            
            var stream = respone.GetResponseStream();
            var streamEncoding = new StreamReader(stream, Encoding.UTF8);
            

            var Jstring = streamEncoding.ReadToEnd().Replace("<b>", "").Replace("</b>", "");
           
            return Jstring;
        }
    }
}
