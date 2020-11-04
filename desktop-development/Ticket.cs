using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_development
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Passenger yolcu = new Passenger();
            yolcu.Show();
            this.Hide();
        }

        private void btnHazır_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            listAd.Items.Add(txtAd.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listIlceler.Items.Add(comboBox1.Text);

            if (radioKadin.Checked == true)
            {
                listCinsiyet.Items.Add(radioKadin.Text);
            }
            if (radioBay.Checked == true)
                listCinsiyet.Items.Add(radioBay.Text);

            listKoltuk.Items.Add("6");
            listSaat.Items.Add(comboBox2.Text);
            listSofor.Items.Add("Ürem Sancaktutan");

            btn6.BackColor = Color.Red;
            btn6.Enabled = false;
            txtAd.Clear();
            txtTelefon.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioBay.Checked = false;
            radioKadin.Checked = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            listAd.Items.Add(txtAd.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listIlceler.Items.Add(comboBox1.Text);

            if (radioKadin.Checked == true)
            {
                listCinsiyet.Items.Add(radioKadin.Text);
            }
            if (radioBay.Checked == true)
                listCinsiyet.Items.Add(radioBay.Text);

            listKoltuk.Items.Add("5");
            listSaat.Items.Add(comboBox2.Text);
            listSofor.Items.Add("Ürem Sancaktutan");

            btn5.BackColor = Color.Red;
            btn5.Enabled = false;
            txtAd.Clear();
            txtTelefon.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioBay.Checked = false;
            radioKadin.Checked = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            listAd.Items.Add(txtAd.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listIlceler.Items.Add(comboBox1.Text);

            if (radioKadin.Checked == true)
            {
                listCinsiyet.Items.Add(radioKadin.Text);
            }
            if (radioBay.Checked == true)
                listCinsiyet.Items.Add(radioBay.Text);

            listKoltuk.Items.Add("4");
            listSaat.Items.Add(comboBox2.Text);
            listSofor.Items.Add("Ürem Sancaktutan");

            btn4.BackColor = Color.Red;
            btn4.Enabled = false;
            txtAd.Clear();
            txtTelefon.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioBay.Checked = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listAd.Items.Add(txtAd.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listIlceler.Items.Add(comboBox1.Text);

            if (radioKadin.Checked == true)
            {
                listCinsiyet.Items.Add(radioKadin.Text);
            }
            if (radioBay.Checked == true)
                listCinsiyet.Items.Add(radioBay.Text);

            listKoltuk.Items.Add("3");
            listSaat.Items.Add(comboBox2.Text);
            listSofor.Items.Add("Ürem Sancaktutan");

            btn3.BackColor = Color.Red;
            btn3.Enabled = false;
            txtAd.Clear();
            txtTelefon.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioBay.Checked = false;
            radioKadin.Checked = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listAd.Items.Add(txtAd.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listIlceler.Items.Add(comboBox1.Text);

            if (radioKadin.Checked == true)
            {
                listCinsiyet.Items.Add(radioKadin.Text);
            }
            if (radioBay.Checked == true)
                listCinsiyet.Items.Add(radioBay.Text);

            listKoltuk.Items.Add("2");
            listSaat.Items.Add(comboBox2.Text);
            listSofor.Items.Add("Ürem Sancaktutan");

            btn1.BackColor = Color.Red;
            btn2.Enabled = false;
            txtAd.Clear();
            txtTelefon.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioBay.Checked = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listAd.Items.Add(txtAd.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listIlceler.Items.Add(comboBox1.Text);

            if (radioKadin.Checked == true)
            {
                listCinsiyet.Items.Add(radioKadin.Text);
            }
            if (radioBay.Checked == true)
                listCinsiyet.Items.Add(radioBay.Text);

            listKoltuk.Items.Add("1");
            listSaat.Items.Add(comboBox2.Text);
            listSofor.Items.Add("Ürem Sancaktutan");

            btn1.BackColor = Color.Red;
            btn1.Enabled = false;
            txtAd.Clear();
            txtTelefon.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioBay.Checked = false;
            radioKadin.Checked = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }
    }
}
