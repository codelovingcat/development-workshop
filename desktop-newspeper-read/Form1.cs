using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using wordeaktar = Microsoft.Office.Interop.Word;

namespace desktop_newspeper_read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlRead = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlRead.Read())
            {
                if (xmlRead.Name == "title")
                {
                    listNews.Items.Add(xmlRead.ReadString());
                    listNews.Items.Add("*** *** ***");
                    listNews.Items.Add(textBox1.Text);
                    textBox1.Text = listNews.Items.Add(xmlRead.ReadString()).ToString();
                }
            }
        }

        private void btnhaber_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlRead = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlRead.Read())
            {
                if (xmlRead.Name == "description")
                {
                    listNews.Items.Add(xmlRead.ReadString());
                    listNews.Items.Add("*** *** ***");
                    textBox1.Text = xmlRead.ReadString();
                }
            }
            listNews.Items.Add("***** HABER AÇIKLAMASI *****");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listNews.Items.Clear();
        }

    }
}
