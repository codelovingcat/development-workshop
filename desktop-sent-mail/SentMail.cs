using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace desktop_sent_mail
{
    public partial class SentMail : Form
    {
        public SentMail()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            //MailMessage mailMessage = new MailMessage();
            //SmtpClient smtpClient = new SmtpClient();

            //smtpClient.Credentials = new System.Net.NetworkCredential("mail@adresiniz.com", "şifreniz");
            //smtpClient.Port = 587;
            //smtpClient.Host = "smtp.live.com";
            //smtpClient.EnableSsl = true;
            //mailMessage.To.Add(txtMesaj.Text);
            //mailMessage.From = new MailAddress("mail@adresiniz.com");
            //mailMessage.Subject = txtKonu.Text;
            //mailMessage.Body = txtMesaj.Text;
            //smtpClient.Send(mailMessage);


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.EnableSsl = true;

            string kime = txtKime.Text;
            string konu = txtKonu.Text;
            string icerik = txtMesaj.Text;

            smtpClient.Credentials = new NetworkCredential("mail@adresiniz.com", "şifreniz");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("mail@adresiniz.com", "Ürem Sancaktutan");
            mail.To.Add(kime);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            //mail.To.Add("mail@adresiniz.com");
            //mail.CC.Add("mail@adresiniz.com");
            //mail.CC.Add("mail@adresiniz.com");
            smtpClient.Send(mail);

        }
    }
}
