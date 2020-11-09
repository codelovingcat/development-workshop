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

namespace desktop_exchange_rate
{
    public partial class Exchange : Form
    {
        public Exchange()
        {
            InitializeComponent();
        }

        private void btnKur_Click(object sender, EventArgs e)
        {

            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xml = new XmlDocument();

            xml.Load(today);

            DateTime date = Convert.ToDateTime(xml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            richTextBox1.Text = string.Format("Tarih : {0} USD ; {1}", date.ToShortDateString(), USD);

            string EURO = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            richTextBox2.Text = string.Format("Tarih : {0} EURO ; {1}", date.ToShortDateString(), EURO);

            string POUND = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            richTextBox3.Text = string.Format("Tarih : {0} POUND ; {1}", date.ToShortDateString(), POUND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            var xml = new XmlDocument();
            string backDay = "http://www.tcmb.gov.tr/kurlar/201001/15012010.xml";

            
            xml.Load(backDay);

            DateTime date = Convert.ToDateTime(xml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            lbl1.Text = string.Format("Tarih : {0} USD ; {1}", date.ToShortDateString(), USD);

            string EURO = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            lbl2.Text = string.Format("Tarih : {0} EURO ; {1}", date.ToShortDateString(), EURO);

            string POUND = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            lbl3.Text = string.Format("Tarih : {0} POUND ; {1}", date.ToShortDateString(), POUND);
        }
    }
}
