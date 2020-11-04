using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_ygs_point
{
    public partial class Yks : Form
    {
        double turkce, matematik, sosyal, fen;
        double yks1, yks2, yks3, yks4, yks5, yks6;
        public Yks()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            turkce = Convert.ToDouble(txtTurkce.Text);
            matematik = Convert.ToDouble(txtMat.Text);
            sosyal = Convert.ToDouble(txtSos.Text);
            fen = Convert.ToDouble(txtFen.Text);

            yks1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.998) + (fen * 2.999);
            lblYgs1.Text = yks1.ToString();

            yks2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 2.999) + (fen * 3.998);
            lblYgs2.Text = yks2.ToString();

            yks3 = 100.160 + (turkce * 3.998) + (sosyal * 2.999) + (matematik * 1.999) + (fen * 1);
            lblYgs3.Text = yks3.ToString();

            yks4 = 100.160 + (turkce * 2.999) + (sosyal * 3.998) + (matematik * 1.999) + (fen * 1);
            lblYgs4.Text = yks4.ToString();

            yks5 = 100.120 + (turkce * 3.699) + (sosyal * 1.999) + (matematik * 3.299) + (fen * 1);
            lblYgs5.Text = yks5.ToString();

            yks6 = 100.120 + (turkce * 3.299) + (sosyal * 1) + (matematik * 3.699) + (fen * 1.999);
            lblYgs6.Text = yks6.ToString();
        }
    }
}
