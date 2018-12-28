using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class TourListDetail : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        PrivateFontCollection privateFonts;
        private string contentID;
        private Image img;
        private DetailCommon detailCommon;
        private List<DetailCommon> detailCommonList = new List<DetailCommon>();
        private List<DetailImage> detailImagesList = new List<DetailImage>();
        private FormTourInformation finfo = new FormTourInformation();

        public TourListDetail()
        {
            InitializeComponent();
        }
      

        public TourListDetail(string contentID, Image img) : this()
        {
            this.contentID = contentID;
            this.img = img;

        }
        private void TourListDetail_Load(object sender, EventArgs e)
        {
            privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(Application.StartupPath + "\\Font\\HannaPro.ttf");
            privateFonts.AddFontFile(Application.StartupPath + "\\Font\\Hanna.ttf");
            lblName.Font = new Font(privateFonts.Families[0], 24f, FontStyle.Bold);
            lblAddr.Font = lblTel.Font = lblZipcode.Font = label1.Font = label2.Font = label3.Font = label4.Font = new Font(privateFonts.Families[1], 11f, FontStyle.Regular);
            tbxOverView.Font = new Font(privateFonts.Families[0], 11f, FontStyle.Regular);
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images\\FormDetailBack.jpg");
            button7.BackgroundImage = Properties.Resources.close.ToImage();
            this.Text = "세부정보";
            imgList.ImageSize = new Size(256, 256);
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            plusImageTrackBar.BackColor = Color.FromArgb(255, 247, 248, 250);
            tbxOverView.BackColor = Color.FromArgb(255, 233, 237, 238);
            string type = string.Empty;
            DetailImage detailImage;
            string getjson = finfo.GetJson("detailImage", "&contentId=" + contentID + "&imageYN=Y", 5);
            JObject jobject = JObject.Parse(getjson);
            JToken jtokens = jobject.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");
            try
            {
                type = jtokens.Type.ToString();
            }
            catch (NullReferenceException)
            {
                type = "Null";
            }
            if (type == "Array")
            {
                JArray jArray = JArray.Parse(jtokens.ToString());
                foreach (var item in jArray)
                {
                    detailImage = new DetailImage
                    {
                        Serialnum = item["serialnum"].ToString(),
                        Originimgurl = item["originimgurl"].ToString()
                    };
                    //detailImagesList.Add(detailImage);
                    AddImageList(detailImage);
                }

            }
            else if (type == "Object")
            {
                detailImage = new DetailImage();
                detailImage.Serialnum = jtokens.SelectToken("serialnum").ToString();
                detailImage.Originimgurl = jtokens.SelectToken("originimgurl").ToString();
                AddImageList(detailImage);
                plusImageTrackBar.Visible = false;
            }
            else
            {
                detailImage = new DetailImage();
                detailImage.Serialnum = "NoImage";
                detailImage.Originimgurl = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                AddImageList(detailImage);
                plusImageTrackBar.Visible = false;
            }
            //pbxPlusImg.Image = imgList.Images[0];
            pbxPlusImg.Image = img;
            plusImageTrackBar.Maximum = imgList.Images.Count - 1;


            string htmlTag = string.Empty;
            string homepage = string.Empty;
            string json = finfo.GetJson("detailCommon", "&contentId=" + contentID + "&defaultYN=Y&addrinfoYN=Y&overviewYN=Y", 1);
            JObject jobj = JObject.Parse(json);
            JToken jtoken = jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");

            if (jtoken.ToString().Contains("homepage"))
            {
                string html = jtoken["homepage"].ToString();
                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);
                try
                {
                    htmlTag = htmlDoc.DocumentNode.SelectSingleNode("//a").InnerText;
                }
                catch (NullReferenceException)
                {
                    htmlTag = html;
                }
            }

            detailCommon = new DetailCommon
            {
                Title = jtoken.ToString().Contains("title") ? jtoken["title"].ToString() : "",
                OverView = jtoken.ToString().Contains("overview") ? jtoken["overview"].ToString().Replace("<br />", " ").Replace("<br>", "").Replace("\n", "").Replace("<strong>", "").Replace("</strong>", "") : "개요 없음.",
                Addr1 = jtoken.ToString().Contains("addr1") ? jtoken["addr1"].ToString() : "주소 없음.",
                Addr2 = jtoken.ToString().Contains("addr2") ? jtoken["addr2"].ToString() : "",
                Tel = jtoken.ToString().Contains("tel") && !jtoken.ToString().Contains("telname") ? jtoken["tel"].ToString() : "전화번호 없음.",
                ContentID = jtoken["contentid"].ToString(),
                ContentTypeID = jtoken["contenttypeid"].ToString(),
                ZipCode = jtoken.ToString().Contains("zipcode") ? jtoken["zipcode"].ToString() : "우편번호 없음.",
                HomePage = htmlTag
            };

            lblName.Text = detailCommon.Title;
            lblAddr.Text = detailCommon.Addr1 + " " + detailCommon.Addr2;
            lblZipcode.Text = detailCommon.ZipCode;
            lblTel.Text = detailCommon.Tel;
            tbxOverView.Text = detailCommon.OverView;
            linkLblHomePage.Text = detailCommon.HomePage;
            if (string.IsNullOrEmpty(linkLblHomePage.Text))
            {
                linkLblHomePage.Text = "홈페이지 없음.";
                linkLblHomePage.Enabled = false;
            }
            
        }

        private void AddImageList(DetailImage detailImage)
        {
            try
            {
                Uri uri = new Uri(detailImage.Originimgurl);
            }
            catch (UriFormatException)
            {
                detailImage.Originimgurl = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
            }

            HttpWebRequest imgRequest = WebRequest.Create(detailImage.Originimgurl) as HttpWebRequest;
            HttpWebResponse imgResponse = imgRequest.GetResponse() as HttpWebResponse;
            Stream stream = imgResponse.GetResponseStream();
            Image img = Image.FromStream(stream);
            imgList.Images.Add(detailImage.Serialnum, img);
        }

        private void linkLblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", linkLblHomePage.Text);
        }

        private void plusImageTrackBar_Scroll(object sender, EventArgs e)
        {
            pbxPlusImg.Image = imgList.Images[plusImageTrackBar.Value];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
