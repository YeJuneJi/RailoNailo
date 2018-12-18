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
    public partial class TourListDetail : Form
    {
        private string contentID;
        private DetailCommon detailCommon;
        private List<DetailCommon> detailCommonList = new List<DetailCommon>();
        private List<DetailImage> detailImagesList = new List<DetailImage>();
        private FormTourInformation finfo = new FormTourInformation();
        
        public TourListDetail()
        {
            InitializeComponent();
        }

        public TourListDetail(string contentID) : this()
        {
            this.contentID = contentID;

        }
        private void TourListDetail_Load(object sender, EventArgs e)
        {
            imgList.ImageSize = new Size(256, 256);
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            string type = string.Empty;
            DetailImage detailImage;
            string getjson = finfo.GetJson("detailImage", "&contentId=" + contentID + "&imageYN=Y", 5);
            JObject jobject = JObject.Parse(getjson);
            //tbxResult.Text = jobject.ToString();
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
            pbxPlusImg.Image = imgList.Images[0];
            plusImageTrackBar.Maximum = imgList.Images.Count - 1;



            int findIndex = 0;
            string homepage = string.Empty;
            string json = finfo.GetJson("detailCommon", "&contentId=" + contentID + "&defaultYN=Y&addrinfoYN=Y&overviewYN=Y", 1);
            JObject jobj = JObject.Parse(json);
            JToken jtoken = jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");
            tbxResult.Text = jtoken.ToString();
            try
            {
                findIndex = jtoken["homepage"].ToString().IndexOf(">") + 1;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (NullReferenceException)
            {
                findIndex = 0;
            }
            finally
            {

                if (jtoken.ToString().Contains("homepage"))
                {
                    homepage = jtoken["homepage"].ToString().Remove(0, findIndex).Replace("</a>", "");
                }
                
                if (homepage.IndexOf("<br") != -1)
                {
                    homepage = homepage.Remove(homepage.IndexOf("<br"), homepage.Length - homepage.IndexOf("<br"));
                }
                else
                {

                }
               
                //tbxResult.Text = jtoken.ToString().Contains("homepage") ? jtoken["homepage"].ToString().Remove(0, findIndex).Replace("</a>", "") : "";
                detailCommon = new DetailCommon
                {
                    Title = jtoken.ToString().Contains("title") ? jtoken["title"].ToString() : "",
                    OverView = jtoken.ToString().Contains("overview") ? jtoken["overview"].ToString().Replace("<br />", " ").Replace("<br>", "").Replace("\n", "").Replace("<strong>", "").Replace("</strong>", "") : "",
                    Addr1 = jtoken.ToString().Contains("addr1") ? jtoken["addr1"].ToString() : "",
                    Addr2 = jtoken.ToString().Contains("addr2") ? jtoken["addr2"].ToString() : "",
                    Tel = jtoken.ToString().Contains("tel") && !jtoken.ToString().Contains("telname") ? jtoken["tel"].ToString() : "",
                    ContentID = jtoken["contentid"].ToString(),
                    ContentTypeID = jtoken["contenttypeid"].ToString(),
                    ZipCode = jtoken.ToString().Contains("zipcode") ? jtoken["zipcode"].ToString() : "",
                    HomePage = jtoken.ToString().Contains("homepage") ? homepage.Remove(homepage.IndexOf("<br"), homepage.Length-homepage.IndexOf("<br")) : ""/*jtoken.ToString().Contains("homepage") ? jtoken["homepage"].ToString() : ""*/
                };

                lblName.Text = detailCommon.Title;
                lblAddr.Text = detailCommon.Addr1 + " " + detailCommon.Addr2;
                lblZipcode.Text = detailCommon.ZipCode;
                lblTel.Text = detailCommon.Tel;
                tbxOverView.Text = detailCommon.OverView;
                linkLblHomePage.Text = detailCommon.HomePage;
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
    }
}
