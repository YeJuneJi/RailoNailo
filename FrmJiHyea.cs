﻿using HtmlAgilityPack;
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
    public partial class FrmJiHyea : Form
    {
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
        }
        //private void Back() {
        //    foreach (Control item in Controls)
        //    {
        //        if (item.GetType().ToString() == "System.Windows.Forms.Label")
        //        {
        //            var pos = this.PointToScreen(item.Location);
        //            foreach (Control item2 in Controls)
        //            {
        //                if (item2.GetType().ToString() == "System.Windows.Forms.PictureBox" && item2.Name.ToString().Substring(item2.Name.Length - 1, 1) == item.Name.ToString().Substring(item.Name.Length - 1, 1))
        //                {
        //                    pos = item2.PointToClient(pos);
        //                    item.Parent = item2;
        //                    item.BackColor = Color.Transparent;
        //                    item.Location = pos;
        //                }
        //            }
        //        }
        //    }
        //}
        private void Display()
        {

            listPic.SendToBack();
            locList = new List<Location>();
            listPic.Image = null;
            timer1.Enabled = false;
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
                                ((PictureBox)item2).Image = Image.FromFile(@"C:\Users\gd12\source\repos\railro.cs\railro.cs\Images\" + item.InnerText.Trim() + ".png");
                            }
                            catch (Exception)
                            {
                                ((PictureBox)item2).Image = Image.FromFile(@"C:\Users\gd12\source\repos\railro.cs\railro.cs\Images\noImage.jpg");
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(0, imageList1.Images.Count - 1);
            listPic.Image = imageList1.Images[num];
        }
    }
}
