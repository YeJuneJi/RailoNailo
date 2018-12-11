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

        private void btnTourInfo_Click(object sender, EventArgs e)
        {
            FormTourInformation formTourInformation = new FormTourInformation();
            formTourInformation.Show();
        }
    }
}
