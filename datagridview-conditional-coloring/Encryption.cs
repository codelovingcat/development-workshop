using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview_conditional_coloring
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string data = "";
            data = textBoxMetin.Text;
            char[] vs = data.ToCharArray();
            foreach (var item in vs)
            {
                textBoxPassword.Text += Convert.ToChar(item +3).ToString();
            }
        }

        private void btnPasswordSolve_Click(object sender, EventArgs e)
        {
            string password = "";
            password = textBoxPassword.Text;
            char[] vs = password.ToCharArray();
            foreach (var item in vs)
            {
                textBoxMetin.Text += Convert.ToChar(item - 3).ToString();
            }
        }
    }
}
