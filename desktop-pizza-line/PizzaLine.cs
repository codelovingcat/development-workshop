using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_pizza_line
{
    public partial class PizzaLine : Form
    {
        public PizzaLine()
        {
            InitializeComponent();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            listAdSoyad.Items.Add(txtAdSoyad.Text);
            listTelefon.Items.Add(txtTelefon.Text);
            listAdres.Items.Add(txtAdres.Text);

            listPizza.Items.Add(comboPizza.Text);
            listIcecek.Items.Add(comboIcecek.Text);

            listExtra.Items.Add(lblBiber.Text + " " + lblKasar.Text + " " + lblMısır.Text + " " + lblSosis.Text + " " + lblSucuk.Text + " " + lblZeytin.Text);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();

            lblBiber.Text = "";
            lblKasar.Text = "";
            lblMısır.Text = "";
            lblSosis.Text = "";
            lblSucuk.Text = "";
            lblZeytin.Text = "";
            comboPizza.Text = "";
            comboIcecek.Text = "";

            checkBiber.Checked = false;
            checkKasar.Checked = false;
            checkMısır.Checked = false;
            checkSosis.Checked = false;
            checkSucuk.Checked = false;
            checkZeytin.Checked = false;
        }

        private void checkSucuk_CheckedChanged(object sender, EventArgs e)
        {

            lblSucuk.Text = checkSucuk.Text;
        }

        private void checkMısır_CheckedChanged(object sender, EventArgs e)
        {
            lblMısır.Text = checkMısır.Text;
        }

        private void checkKasar_CheckedChanged(object sender, EventArgs e)
        {
            lblKasar.Text = checkKasar.Text;
        }

        private void checkZeytin_CheckedChanged(object sender, EventArgs e)
        {
            lblZeytin.Text = checkZeytin.Text;
        }

        private void checkBiber_CheckedChanged(object sender, EventArgs e)
        {
            lblBiber.Text = checkBiber.Text;
        }

        private void checkSosis_CheckedChanged(object sender, EventArgs e)
        {
            lblSosis.Text = checkSosis.Text;
        }
    }
}
