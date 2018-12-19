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
    public partial class FrmTrain : Form
    {
        private string serviceKey = "wUgEE5qg4tz1YpeF9csbrTyZ5vsk1AcTEGd%2B7cpaie8Fl8ZCahq3rrl1Z1ZdFdX2xqRRcjzo00AGc%2BgjM3AppA%3D%3D";
        public FrmTrain()
        {
            InitializeComponent();
        }
        private string getjson()
        {
            int pageNo = 10;
            int pageNum = 1;
            string depPlaceId = "NAT010000"; //출발지 ID
            string arrPlaceId = "NAT011668"; //도착지 ID
            string depPlanTime = "20181201";
            string serverurl = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo?serviceKey=wUgEE5qg4tz1YpeF9csbrTyZ5vsk1AcTEGd%2B7cpaie8Fl8ZCahq3rrl1Z1ZdFdX2xqRRcjzo00AGc%2BgjM3AppA%3D%3D&pageSize=20&pageNo=" + pageNo + "&startPage=" + pageNum + "&depPlaceId="+ depPlaceId + "&arrPlaceId="+arrPlaceId+"&depPlandTime="+depPlanTime+"&_type=json";
        }
    }
}
