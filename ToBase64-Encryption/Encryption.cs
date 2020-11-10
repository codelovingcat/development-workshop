using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToBase64_Encryption
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string text = textBoxMetin.Text;
            byte[] data = ASCIIEncoding.ASCII.GetBytes(text);

            string PasswordText = Convert.ToBase64String(data);
            textBoxPassword.Text = PasswordText;

        }

        private void btnPasswordSolve_Click(object sender, EventArgs e)
        {
            string textSolve = textBoxPassword.Text;
            byte[] dataSolve = Convert.FromBase64String(textSolve);

            string mainText = ASCIIEncoding.ASCII.GetString(dataSolve);
            textBoxMetin.Text = mainText;
        }
    }
}
