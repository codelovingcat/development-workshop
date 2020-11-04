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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" || txtUser.Text == "Admin" && txtPasword.Text == "1" || txtPasword.Text == "123")
            {
                Passenger yolcu = new Passenger();
                yolcu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya şifre yanlış.");
            }
        }
    }
}
