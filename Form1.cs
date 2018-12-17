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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJihyea_Click(object sender, EventArgs e)
        {
            FrmJiHyea fjh = new FrmJiHyea();
            fjh.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            FrmPlan fp = new FrmPlan();
            fp.ShowDialog();
        }
        private void btnTourInfo_Click(object sender, EventArgs e)
        {
            FormTourInformation formTourInformation = new FormTourInformation();
            formTourInformation.Show();
        }
    }
}
