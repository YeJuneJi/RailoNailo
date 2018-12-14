using HtmlAgilityPack;
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
using System.Drawing.Text;

namespace RailoNailo
{
    public partial class HoneyTip : Form
    {
        public HoneyTip()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();

            privateFonts.AddFontFile(@"C:\Railo\한나체!.ttf");
            Font font = new Font(privateFonts.Families[0], 14f);

            btnImg1.Font = btnImg2.Font = btnImg3.Font = btnImg4.Font = btnImg5.Font = btnImg6.Font = btnImg7.Font = btnImg8.Font = btnImg9.Font = font;
        }
        private int displayPage = 9;
        private int totalPage = 0; //전체 페이지
        private int currPage = 0; //현재 페이지
        int temp = 1;
        //string[] photo = { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
        string[] a = new string[27]; //제목, 블로그 이름(+9), 링크 (+18)

        private void HoneyTip_Load(object sender, EventArgs e)
        {
            btnImg1.FlatStyle = FlatStyle.Flat;
            
            //뒷배경을 투명처리(transparent)로 하실려면 아래 추가해주면됩니다. 
            btnImg1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnImg1.BackColor = Color.FromArgb(0, 255, 255, 255);
            string honeyTipTitle = "";
            if (radioButton1.Checked)
            {
                honeyTipTitle = HttpUtility.UrlEncode("내일로");
            }
            else
            {
                honeyTipTitle = HttpUtility.UrlEncode("내일로 여행후기");
            }
            blogSearch(honeyTipTitle);
        }

        private void blogSearch(string honeyTipTitle)
        {
            int aa = currPage * displayPage;
            if (aa == 0)
            {
                aa = 1;
            }
            string serverUrl = "https://openapi.naver.com/v1/search/blog.json?query=" + honeyTipTitle + "&display=" + displayPage + "&start=" + aa;
            
            JObject honeyTipData = JObject.Parse(JsonConnetInfo(serverUrl));//제이슨 연결후 데이터 가져옴 가져온데이터 JObject타입으로 캐스팅

            int totalData = Int32.Parse(honeyTipData["total"].ToString()); //전체 데이터수            
            totalPage = totalData / displayPage;
            if (totalData % displayPage != 0)
            {
                totalPage += 1;
            }
            label1.Text = temp + "/" + totalPage;

            var honeyTipArray = JArray.Parse(honeyTipData["items"].ToString());

            for (int i = 0; i < honeyTipArray.Count; i++)
            {
                a[i] = honeyTipArray[i]["title"].ToString();
                if (honeyTipArray[i]["bloggername"].ToString().Length > 15)
                {
                    a[i + 9] = honeyTipArray[i]["bloggername"].ToString().Remove(14, honeyTipArray[i]["bloggername"].ToString().Length - 14);
                }
                else
                {
                    a[i + 9] = honeyTipArray[i]["bloggername"].ToString();
                }
                a[i + 18] = honeyTipArray[i]["link"].ToString().Replace("?Redirect=Log&amp;logNo=", "/");
            }
            //WebRequest req = WebRequest.Create("http://postfiles4.naver.net/MjAxODEyMTFfMTI1/MDAxNTQ0NTA5ODg2OTc1.E52pKHu18Bsbne9IT8KUaRoow_vy0gaYIvB9c-3xl-Ig.M7MUhj3laUHgZwTh0A52_nICv6tZoTCtS9GlqHPko78g.JPEG.overroad89/main.jpg");
            //WebResponse res = req.GetResponse();
            //Stream stream = res.GetResponseStream();            

            //btnImg1.BackgroundImage = Image.FromStream(stream);
            //btnImg2.BackgroundImage = Image.FromFile(@"C:\Railo\1.png");
            //btnImg3.BackgroundImage = Image.FromFile(@"C:\Railo\2.png");  
            //btnImg3.BackgroundImage = new SolidBrush(Color.FromArgb(50, 255, 0, 0));            
            
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
        }

        private string JsonConnetInfo(string serverUrl) //연결
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

        private void button1_Click(object sender, EventArgs e) //이전버튼
        {
            
            if (currPage > 0 ) 
            {
                currPage--;
                temp--;
                HoneyTip_Load(null, null);
            }
            else
            {
                MessageBox.Show("첫번째 페이지");
            }            
        }

        private void button2_Click(object sender, EventArgs e) //다음버튼
        {            
            if (currPage<totalPage)
            {
                currPage++;
                temp++;
                HoneyTip_Load(null, null);
            }
            else
            {
                MessageBox.Show("마지막 페이지");
            }
        }

        private void button3_Click(object sender, EventArgs e) //첫페이지
        {
            currPage = 0;
            temp = 1;
            HoneyTip_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e) //마지막페이지
        {
            currPage = totalPage-2;
            HoneyTip_Load(null, null);
        }

        private void btnImg1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[18]);
        }

        private void btnImg2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[19]);
        }

        private void btnImg3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[20]);
        }

        private void btnImg4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[21]);
        }

        private void btnImg5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[22]);
        }

        private void btnImg6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[23]);
        }

        private void btnImg7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[24]);
        }

        private void btnImg8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[25]);
        }

        private void btnImg9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(a[26]);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//내일로여행 추천 체크시 정보출력
        {
            if (radioButton1.Checked)
            {
                lblMainTitle.Text = "내일로 여행 꿀팁!";
                
                displayPage = 9;
                totalPage = 0; 
                currPage = 0;
                temp = 1;
                HoneyTip_Load(null, null);
                this.BackgroundImage = Image.FromFile(@"C:\Railo\honeyTipImage\main4.PNG");
            }            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //내일로 후기 체크시 정보출력
        {
            if (radioButton2.Checked)
            {
                lblMainTitle.Text = "내일로 여행 후기!";
                displayPage = 9;
                totalPage = 0;
                currPage = 0;
                temp = 1;
                this.BackgroundImage = Image.FromFile(@"C:\Railo\honeyTipImage\Main22.png");
                HoneyTip_Load(null, null);                
            }
        }        
    }
}
