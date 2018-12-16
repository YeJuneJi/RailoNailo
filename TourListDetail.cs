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
            tbxResult.Text += json;
        }
    }
}
