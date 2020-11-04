using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_stay_in_shape
{
    public partial class StayShape : Form
    {
        public StayShape()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kilo, boy, index;

            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);

            index = kilo / (boy * boy);

            lblIndexSonuc.Text = index.ToString();

            if (index < 18)
            {
                lblDurum.Text = "İstediğinizi yiyebilirsiniz. Çok Zayıfsınız.";
            }
            else if (index >= 18 && index < 25)
            {
                lblDurum.Text = "Henüz korkacak bir şey yok. Normalsiniz.";
            }
            else if (index >= 25 && index <= 30)
            {
                lblDurum.Text = "Spora ve diyete başlayın. Kilolusunuz.";
            }
            else if (index >= 30 && index <= 35)
            {
                lblDurum.Text = "Dikkat!!! Obezsiniz.";
            }
            else
            {
                lblDurum.Text = "Çok fena ciddi Obezsiniz!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoy.Clear();
            txtKilo.Clear();

            
            lblDurum.Text = "";
            lblIndexSonuc.Text = "";
          
        }
    }
}
