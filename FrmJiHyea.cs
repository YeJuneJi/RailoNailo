using HtmlAgilityPack;
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
    public partial class FrmJiHyea : Form
    {
        PrivateFontCollection privateFonts;
        PrivateFontCollection privateFonts2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        Uri uri;
        HttpWebRequest request;
        HttpWebResponse response;
        Stream stream;
        int locNum = 1;
        public FrmJiHyea()
        {
            InitializeComponent();
        }
        List<Location> locList;
        Location loc;
        private void FrmJiHyea_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.close.ToImage();
            this.BackgroundImage= Image.FromFile(Application.StartupPath + "\\Images\\mainBackground2.jpg");

            privateFonts2 = new PrivateFontCollection();
            privateFonts2.AddFontFile(Application.StartupPath + "\\Font\\HannaPro.ttf");
            Font font2 = new Font(privateFonts2.Families[0], 16f);
            lblCenter.Font = font2;
        }
        private void Display()
        {
            locList = new List<Location>();
            foreach (Control item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    item.Text = null;
                }
                if (item.GetType().ToString()== "System.Windows.Forms.PictureBox")
                {
                    ((PictureBox)item).Image = null;
                }
            }
            string path = "http://www.rail-ro.com/kor/benefit/menu_01.html?a=1&pmode=list&station01=" + locNum + "&page=1";
            this.uri = new Uri(path);
            request = WebRequest.Create(uri) as HttpWebRequest;
            response = request.GetResponse() as HttpWebResponse;
            int pNum = 1;
            int lNum = 1;
            stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream, Encoding.UTF8);
            string webString = sr.ReadToEnd();

            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(webString);
            HtmlNode body = htmlDoc.DocumentNode.SelectSingleNode("//body");
            foreach (var item in body.SelectNodes("//div"))
            {
                if (item.GetAttributeValue("class", "") == "station-thumb")
                {
                    loc = new Location();
                    foreach (Control item2 in Controls)
                    {
                        if (item2.GetType().ToString() == "System.Windows.Forms.Label" && item2.Name == "label" + lNum)
                        {
                            item2.Text = loc.LocName = item.InnerText.Trim();
                            lNum++;
                            break;
                        }
                    }
                    foreach (Control item2 in Controls)
                    {
                        if (item2.GetType().ToString() == "System.Windows.Forms.PictureBox" && item2.Name == "pictureBox" + pNum)
                        {
                            try
                            {
                                ((PictureBox)item2).Image = Image.FromFile(Application.StartupPath + "\\Images\\" + Translation.translationText(item.InnerText.Trim()) + ".png");
                            }
                            catch (Exception)
                            {
                                ((PictureBox)item2).Image = Image.FromFile(Application.StartupPath + "\\Images\\noImage.jpg");
                            }
                            
                            ((PictureBox)item2).Click += FrmJiHyea_Click;
                            pNum++;
                            break;
                        }
                    }

                    loc.Link = "http://www.rail-ro.com/kor/benefit/menu_01.html?a=1&pmode=view&station01=" + item.ParentNode.GetAttributeValue("data-station01", "") + "&station02="+ item.ParentNode.GetAttributeValue("data-station02", "") +"&page=1";
                    locList.Add(loc);
                }
                
            }
            privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(Application.StartupPath + "\\Font\\HannaPro.ttf");
            Font font = new Font(privateFonts.Families[0], 10f);



            foreach (Control item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.Label")
                {
                    item.Font = font;
                }
            }
        }

        private void FrmJiHyea_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < locList.Count+1; i++)
            {
                if (((PictureBox)sender).Name.Substring(10, 1) == i.ToString())
                {
                    System.Diagnostics.Process.Start(locList[i-1].Link);
                    break;
                }
            }
        }

        private void cbbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbLocation.Text)
            {
                case "수도권":
                    locNum = 1;
                    Display();
                    break;
                case "강원권":
                    locNum = 2;
                    Display();
                    break;
                case "충청권":
                    locNum = 3;
                    Display();
                    break;
                case "전라권":
                    locNum = 4;
                    Display();
                    break;
                case "경상권":
                    locNum = 5;
                    Display();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
