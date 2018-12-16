using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string json = finfo.GetJson("detailCommon", "&contentId=" + contentID + "&defaultYN=Y&addrinfoYN=Y&overviewYN=Y", 1);
            JObject jobj = JObject.Parse(json);
            JToken jtoken = jobj.SelectToken("response").SelectToken("body").SelectToken("items").SelectToken("item");
            detailCommon = new DetailCommon
            {
                Title = jtoken["title"].ToString(),
                OverView = jtoken["overview"].ToString(),
                Addr1 = jtoken.ToString().Contains("addr1") ? jtoken["addr1"].ToString() : "",
                Addr2 = jtoken.ToString().Contains("addr2") ? jtoken["addr2"].ToString() : "",
                Tel = jtoken.ToString().Contains("tel") ? jtoken["tel"].ToString() : "",
                ContentID = jtoken["contentid"].ToString(),
                ContentTypeID = jtoken["contenttypeid"].ToString(),
                ZipCode = jtoken.ToString().Contains("zipcode") ? jtoken["zipcode"].ToString() : "",
                HomePage = jtoken.ToString().Contains("homepage") ? jtoken["homepage"].ToString() : ""
            };

            lblName.Text = detailCommon.Title;
            lblAddr.Text = detailCommon.Addr1 + " " + detailCommon.Addr2;
            lblZipcode.Text = detailCommon.ZipCode;
            lblTel.Text = detailCommon.Tel;
            tbxOverView.Text = detailCommon.OverView;
            linkLblHomePage.Text = detailCommon.HomePage;
        }

        private void linkLblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", linkLblHomePage.Text);
        }
    }
}
