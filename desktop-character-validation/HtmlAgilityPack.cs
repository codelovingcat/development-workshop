using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace desktop_character_validation
{
    public partial class HtmlAgilityPack : Form
    {
        public HtmlAgilityPack()
        {
            InitializeComponent();
        }

        private void btnHtmlAgilityPack_Click(object sender, EventArgs e)
        {
            string http = "http://www.meb.gov.tr";
            WebRequest request = HttpWebRequest.Create(http);
            WebResponse response;
            response = request.GetResponse();

            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            string comeDate = streamReader.ReadToEnd();
            int titleStart = comeDate.IndexOf("<title>") + 7;
            int titleEnd = comeDate.Substring(titleStart).IndexOf("</title>");
            string title = comeDate.Substring(titleStart, titleEnd);
            MessageBox.Show(title);

            
        }
    }
}
