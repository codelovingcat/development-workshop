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

namespace desktop_google_translate
{
    public partial class GoogleTranslate : Form
    {
        public GoogleTranslate()
        {
            InitializeComponent();
        }
        public bool test()
        {
            string address = "http://www.google.com";
            try
            {
                WebRequest istek = WebRequest.Create(address);
                WebResponse yanit = istek.GetResponse();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void GoogleTranslate_Load(object sender, EventArgs e)
        {
            if (test())
            {
                this.Text = "Bağlantı var.";
            }
            else
            {
                this.Text = "Bağlantı yok.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioBtnTr.Checked == true)
            {
                richTextBox1.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
            if (radioBtnEng.Checked == true)
            {
                richTextBox2.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox2.Text;
        }
    }
}
