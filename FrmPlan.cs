﻿using System;
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
    public partial class FrmPlan : Form
    {
        private string locString;

        public string LocString { get => locString; set => locString = value; }

        public FrmPlan()
        {
            InitializeComponent();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateStart.Value<DateTime.Now)
            {
                MessageBox.Show("시작 일은 오늘보다 전 날 일수 없습니다.");
                dateStart.Value = DateTime.Now;
                return;
            }
            else
            {
                if (rdoDay7.Checked)
                {
                    dateFinal.Value = dateStart.Value.AddDays(7);
                }
                else if (rdoDay5.Checked)
                {
                    dateFinal.Value = dateStart.Value.AddDays(5);
                }
                else
                {
                    dateFinal.Value = dateStart.Value.AddDays(3);
                }
                label3.Text = dateStart.Value.ToShortDateString() + " 부터 " + dateFinal.Value.ToShortDateString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPlan_Load(object sender, EventArgs e)
        {
            
            foreach (Control item in groupBox3.Controls)
            {
                if (item.GetType().ToString()=="System.Windows.Forms.PictureBox"&&!(item.Name.Contains("Cross")))
                {
                    item.Click += PictureBoxClick;
                }
            }
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            FrmPlan2 fp2 = new FrmPlan2();
            fp2.Owner = this;
            fp2.ShowDialog();

            if (!string.IsNullOrEmpty(locString))
            {
                ((PictureBox)sender).SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    ((PictureBox)sender).Image = Image.FromFile(@"C:\Users\gd12\source\repos\railro.cs\railro.cs\Images\" + locString + ".png");
                    ((PictureBox)sender).Image.Tag = LocString;
                }
                catch (Exception)
                {
                    ((PictureBox)sender).Image = Image.FromFile(@"C:\Users\gd12\source\repos\railro.cs\railro.cs\Images\noImage.jpg");
                    ((PictureBox)sender).Image.Tag = LocString;
                }
                foreach (Control item in groupBox3.Controls)
                {
                    if (item.GetType().ToString() == "System.Windows.Forms.Label" && item.Name.Contains(((PictureBox)sender).Name))
                    {
                        item.Tag = LocString;
                        item.Text = LocString;
                        break;
                    }
                } 
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
