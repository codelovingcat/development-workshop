using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_soccer_league
{
    public partial class League : Form
    {
        Random random = new Random();

        int besiktasPuan = 0;
        int trabzonPuan = 0;
        int fenerPuan = 0;
        int galataPuan = 0;
        public League()
        {
            InitializeComponent();
        }

        private void btnSampiyon_Click(object sender, EventArgs e)
        {
            int sampiyon = 0;
            if (Convert.ToInt32(lblPuanBesiktas.Text) > Convert.ToInt32(lblPuanFener.Text) && Convert.ToInt32(lblPuanBesiktas.Text) > Convert.ToInt32(lblPuanGalata.Text) && Convert.ToInt32(lblPuanBesiktas.Text) > Convert.ToInt32(lblPuanTrabzon.Text))
            {
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\besiktas.png";
                axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\besiktas.mp3";
                lblResult.Text = "Şampiyon Beşiktaş!...";
            }
            if (Convert.ToInt32(lblPuanFener.Text) > Convert.ToInt32(lblPuanBesiktas.Text) && Convert.ToInt32(lblPuanFener.Text) > Convert.ToInt32(lblPuanGalata.Text) &&
                Convert.ToInt32(lblPuanFener.Text) > Convert.ToInt32(lblPuanTrabzon.Text))
            {
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\fenerbahce.jpg";
                axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\fener.mp3";
                lblResult.Text = "Şampiyon Fenerbahçe!...";
            }
            if (Convert.ToInt32(lblPuanGalata.Text) > Convert.ToInt32(lblPuanBesiktas.Text) && Convert.ToInt32(lblPuanGalata.Text) > Convert.ToInt32(lblPuanFener.Text) &&
                Convert.ToInt32(lblPuanGalata.Text) > Convert.ToInt32(lblPuanTrabzon.Text))
            {
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\galatasaray.jpg";
                axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\galatasaray.mp3";
                lblResult.Text = "Şampiyon Galatasaray!...";
            }
            if (Convert.ToInt32(lblPuanTrabzon.Text) > Convert.ToInt32(lblPuanBesiktas.Text) && Convert.ToInt32(lblPuanTrabzon.Text) > Convert.ToInt32(lblPuanFener.Text) &&
               Convert.ToInt32(lblPuanTrabzon.Text) > Convert.ToInt32(lblPuanGalata.Text))
            {
                pictureBox1.ImageLocation = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\trabzon.jpg";
                axWindowsMediaPlayer1.URL = @"C:\Users\urems\source\repos\development-workshop\desktop-soccer-league\image-music\trabzon.mp3";
                lblResult.Text = "Şampiyon Trabzonspor!...";
            }
        }

        private void btnHafta1_Click(object sender, EventArgs e)
        {
            btnHafta1.Enabled = false;
            int besiktas, fener, trabzon, galata;

            besiktas = random.Next(0, 10);
            lblBesiktas.Text = besiktas.ToString();

            trabzon = random.Next(0, 10);
            lblTrabzon.Text = trabzon.ToString();

            fener = random.Next(0, 10);
            lblFener.Text = fener.ToString();

            galata = random.Next(0, 10);
            lblGalata.Text = galata.ToString();

            //Puanlama
            if (Convert.ToInt32(lblBesiktas.Text) > Convert.ToInt32(lblTrabzon.Text))
            {
                besiktasPuan = besiktasPuan + 3;
                lblPuanBesiktas.Text = besiktasPuan.ToString();
            }

            if (Convert.ToInt32(lblTrabzon.Text) > Convert.ToInt32(lblBesiktas.Text))
            {
                trabzonPuan = trabzonPuan + 3;
                lblPuanTrabzon.Text = trabzonPuan.ToString();
            }

            if (Convert.ToInt32(lblBesiktas.Text) == Convert.ToInt32(lblTrabzon.Text))
            {
                trabzonPuan = trabzonPuan + 1;
                besiktasPuan = besiktasPuan + 1;

                lblPuanTrabzon.Text = trabzonPuan.ToString();
                lblPuanBesiktas.Text = besiktasPuan.ToString();
            }


            if (Convert.ToInt32(lblFener.Text) > Convert.ToInt32(lblGalata.Text))
            {
                fenerPuan = fenerPuan + 3;
                lblPuanFener.Text = fenerPuan.ToString();
            }


            if (Convert.ToInt32(lblGalata.Text) > Convert.ToInt32(lblFener.Text))
            {
                galataPuan = galataPuan + 3;
                lblPuanGalata.Text = galataPuan.ToString();
            }


            if (Convert.ToInt32(lblFener.Text) == Convert.ToInt32(lblGalata.Text))
            {
                fenerPuan = fenerPuan + 1;
                galataPuan = galataPuan + 1;

                lblPuanFener.Text = fenerPuan.ToString();
                lblPuanGalata.Text = galataPuan.ToString();
            }

        }

        private void btnIkinciHafta_Click(object sender, EventArgs e)
        {
            btnIkinciHafta.Enabled = false;
            int besiktas, fener, trabzon, galata;

            besiktas = random.Next(0, 10);
            lblBesiktas2.Text = besiktas.ToString();

            trabzon = random.Next(0, 10);
            lblTrabzon2.Text = trabzon.ToString();

            fener = random.Next(0, 10);
            lblFener2.Text = fener.ToString();

            galata = random.Next(0, 10);
            lblGalata2.Text = galata.ToString();

            //Puanlama
            if (Convert.ToInt32(lblBesiktas2.Text) > Convert.ToInt32(lblGalata2.Text))
            {
                besiktasPuan = besiktasPuan + 3;
                lblPuanBesiktas.Text = besiktasPuan.ToString();
            }

            if (Convert.ToInt32(lblGalata2.Text) > Convert.ToInt32(lblBesiktas2.Text))
            {
                galataPuan = galataPuan + 3;
                lblPuanGalata.Text = galataPuan.ToString();
            }

            if (Convert.ToInt32(lblBesiktas2.Text) == Convert.ToInt32(lblGalata2.Text))
            {
                galataPuan = galataPuan + 1;
                besiktasPuan = besiktasPuan + 1;

                lblPuanGalata.Text = galataPuan.ToString();
                lblPuanBesiktas.Text = besiktasPuan.ToString();
            }


            if (Convert.ToInt32(lblFener2.Text) > Convert.ToInt32(lblTrabzon2.Text))
            {
                fenerPuan = fenerPuan + 3;
                lblPuanFener.Text = fenerPuan.ToString();
            }


            if (Convert.ToInt32(lblTrabzon2.Text) > Convert.ToInt32(lblFener2.Text))
            {
                trabzonPuan = trabzonPuan + 3;
                lblPuanTrabzon.Text = trabzonPuan.ToString();
            }


            if (Convert.ToInt32(lblFener2.Text) == Convert.ToInt32(lblTrabzon2.Text))
            {
                fenerPuan = fenerPuan + 1;
                trabzonPuan = trabzonPuan + 1;

                lblPuanFener.Text = fenerPuan.ToString();
                lblPuanTrabzon.Text = trabzonPuan.ToString();
            }
        }

        private void btnUcuncuHafta_Click(object sender, EventArgs e)
        {
            btnUcuncuHafta.Enabled = false;
            int besiktas, fener, trabzon, galata;

            besiktas = random.Next(0, 10);
            lblBesiktas3.Text = besiktas.ToString();

            trabzon = random.Next(0, 10);
            lblTrabzon3.Text = trabzon.ToString();

            fener = random.Next(0, 10);
            lblFener3.Text = fener.ToString();

            galata = random.Next(0, 10);
            lblGalata3.Text = galata.ToString();

            //Puanlama
            if (Convert.ToInt32(lblBesiktas3.Text) > Convert.ToInt32(lblFener3.Text))
            {
                besiktasPuan = besiktasPuan + 3;
                lblPuanBesiktas.Text = besiktasPuan.ToString();
            }

            if (Convert.ToInt32(lblFener3.Text) > Convert.ToInt32(lblBesiktas3.Text))
            {
                fenerPuan = fenerPuan + 3;
                lblPuanGalata.Text = fenerPuan.ToString();
            }

            if (Convert.ToInt32(lblBesiktas3.Text) == Convert.ToInt32(lblFener3.Text))
            {
                fenerPuan = fenerPuan + 1;
                besiktasPuan = besiktasPuan + 1;

                lblPuanGalata.Text = galataPuan.ToString();
                lblPuanBesiktas.Text = besiktasPuan.ToString();
            }


            if (Convert.ToInt32(lblGalata3.Text) > Convert.ToInt32(lblTrabzon3.Text))
            {
                galataPuan = galataPuan + 3;
                lblPuanGalata.Text = galataPuan.ToString();
            }


            if (Convert.ToInt32(lblTrabzon3.Text) > Convert.ToInt32(lblGalata3.Text))
            {
                trabzonPuan = trabzonPuan + 3;
                lblPuanTrabzon.Text = trabzonPuan.ToString();
            }


            if (Convert.ToInt32(lblGalata3.Text) == Convert.ToInt32(lblTrabzon3.Text))
            {
                galataPuan = galataPuan + 1;
                trabzonPuan = trabzonPuan + 1;

                lblPuanGalata.Text = galataPuan.ToString();
                lblPuanTrabzon.Text = trabzonPuan.ToString();
            }
        }
    }
}
