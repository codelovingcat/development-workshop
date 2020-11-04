using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_web_browser
{
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.flypgs.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.turkishairlines.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.filmloverss.com/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.mgm.gov.tr/FTPDATA/analiz/1218buyuk.PNG");
        }
    }
}
