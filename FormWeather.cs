using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RailoNailo
{
    public partial class FormWeather : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private Weather weather;
        private string weatherKey = "e0830184b177fdc64b093779164ea8a8";
        private string city = "seoul";




        private FormTourInformation ft = new FormTourInformation();
        public FormWeather()
        {
            InitializeComponent();
        }

        private void FormWeather_Load(object sender, EventArgs e)
        {
            this.Text = "오늘의 날씨";
            btnClose.Image = Properties.Resources.close2.ToImage();
            weather = CheckWeather(getJsonWeather(city));

            lblTemp.Text = Math.Round(weather.Temp - 273.15, 2).ToString() + " 도(섭씨)";
            lblPress.Text = weather.Press.ToString() + " 기압(hPa)";
            lblMaxTemp.Text = Math.Round(weather.Maxtemp - 273.15, 2).ToString() + " 도(섭씨)";
            lblMinTemp.Text = Math.Round(weather.Mintemp - 273.15, 2).ToString() + " 도(섭씨)";
        }

        internal string getJsonWeather(string city)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Images\\weather.jpg");
            string serverURL = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=" + weatherKey;
            HttpWebRequest request = WebRequest.Create(serverURL) as HttpWebRequest;
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

        internal Weather CheckWeather(string json)
        {
            Weather weather = new Weather();
            JObject jobj = JObject.Parse(json);
            JArray jWeather = JArray.Parse(jobj.SelectToken("weather").ToString());
            JToken jmain = jobj.SelectToken("main");
            foreach (var item in jWeather)
            {
                lblWeather.Text = item["main"].ToString();
                weather.Id = Convert.ToInt32(item["id"]);
                weather.HowWeather = Convert.ToString(item["main"]);
            }

            weather.Temp = Convert.ToDouble(jmain["temp"]);
            weather.Press = Convert.ToDouble(jmain["pressure"]);
            weather.Maxtemp = Convert.ToDouble(jmain["temp_max"]);
            weather.Mintemp = Convert.ToDouble(jmain["temp_min"]);
            return weather;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
