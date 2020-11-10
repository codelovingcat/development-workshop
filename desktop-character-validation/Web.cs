using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace desktop_character_validation
{
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.onedio.com");
            WebClient client = new WebClient();
            string html = client.DownloadString(uri);
            var document = new HtmlDocument();
            document.LoadHtml(html);

            HtmlNodeCollection htmlNodes = document.DocumentNode.SelectNodes("//a");//anasayfadan ki verileri getir.
            foreach (var item in htmlNodes)
            {
                listBox1.Items.Add(item.InnerText);
            }
        }
    }
}
