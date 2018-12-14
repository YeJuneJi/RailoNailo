using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(@"C:\Railo\한나체!.ttf");
            Font font = new Font(privateFonts.Families[0], 16f);
            btnHoneyTip.Font = btn2.Font = btn1.Font = btn4.Font = font;
        }

        private void btnHoneyTip_Click(object sender, EventArgs e)
        {
            HoneyTip ht = new HoneyTip();
            ht.Show();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }
    }
}
