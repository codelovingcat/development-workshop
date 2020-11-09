using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_psychological_analysis
{
    public partial class Psychological : Form
    {
        int question, total;
        public Psychological()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            total = total + 1;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            total = total + 2;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            total = total + 3;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            total = total + 4;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            total = total + 5;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btnStart.Enabled = true;
        }

        private void Psychological_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\meditasyon.mp3";
            axWindowsMediaPlayer1.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "İleri";
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btnStart.Enabled = false;
            question++;
            if (question == 1)
            {
                pictureBox2.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\woman.gif";
                pictureBox3.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\man.gif";
                pictureBox4.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\child.gif";
                pictureBox5.ImageLocation = @"DD:\GitHub\workshop-development\desktop-psychological-analysis\images\gay.gif";
                txtQuestion.Text = "1. Öncelikle, cinsiyetini seçer misin?";
                btn1.Text = "Kadın";
                btn2.Text = "Erkek";
                btn3.Text = "Ne fark eder?";
                btn4.Text = "Çocuk";
                btn5.Text = "Ne sizden ne bizden";

            }
            if (question == 2)
            {
                //pictureBox2.ImageLocation = @"D:\Git-Github\development-workshop\desktop-psychological-analysis\images\18.jpg";
                //pictureBox3.ImageLocation = @"D:\Git-Github\development-workshop\desktop-psychological-analysis\images\s-24.png";
                //pictureBox4.ImageLocation = @"D:\Git-Github\development-workshop\desktop-psychological-analysis\images\35.png";
                //pictureBox5.ImageLocation = @"D:\Git-Github\development-workshop\desktop-psychological-analysis\images\45.jpg";
                txtQuestion.Text = "2. Şimdi de yaşını söyler misin?";
                btn1.Text = "18 Altı";
                btn2.Text = "18-24";
                btn3.Text = "25-34";
                btn4.Text = "35-44";
                btn5.Text = "45 ve Üstü";

            }
            if (question == 3)
            {
                pictureBox1.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\q3.jpg";
                txtQuestion.Text = "3. Sence bu kadın tek başına denize karşı oturmuş ne düşünüyor?";
                btn1.Text = "Çektiği acıların yükünü hafifletmek için yalnız kalmak istiyor...";
                btn2.Text = "Onlarca insanın içinde güveneceği birinin olmadığını hissedip yalnız olduğunu düşünüyor...";
                btn3.Text = "Kimsenin ona istediği değeri vermediğini düşünüp üzülüyor...";
                btn4.Text = "Özlemini çektiği şeyleri düşünüp içleniyor...";
                btn5.Text = "Kızgınlığını atmak için sakin kalmaya çalışıyor...";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;

            }
            if (question == 4)
            {
                pictureBox1.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\q4.gif";
                txtQuestion.Text = "4. Peki hiç haz etmediğin bir insanın çok acı çekip ağladığını gördün. Bu seni nasıl hissettirir?";
                btn1.Text = "Suçlu";
                btn2.Text = "Üzgün";
                btn3.Text = "Çaresiz";
                btn4.Text = "Mutlu";
                btn5.Text = "Kaygılı";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;

            }
            if (question == 5)
            {
                pictureBox1.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\q5.gif";
                txtQuestion.Text = "Hayalini kurduğun ve emek verdiğin şey gerçekleşmedi diyelim. Ne kadar öfkelenirsin? ( 1= Hiç, 5 = Çok )?";
                btn1.Text = "1";
                btn2.Text = "2";
                btn3.Text = "3";
                btn4.Text = "4";
                btn5.Text = "5";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            if (question == 6)
            {
                pictureBox1.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\q6.gif";
                txtQuestion.Text = "6. Bunca kalabalığın içinde kendini yalnız hissedip insanlara derdini anlatamadığın anlar oluyor mu?";
                btn1.Text = "Her zaman böyleydim, hala da böyleyim...";
                btn2.Text = "Zaman zaman bunu hissediyorum.";
                btn3.Text = "Yanımda olmayan insanları tek tek hayatımdan çıkarıyorum. Sonuç, yine yalnızım...";
                btn4.Text = "Hayır, sevdiğim insanlar her zaman yanımda oluyorlar.";
                btn5.Text = "Boş şeyler bunlar yahu.";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            if (question == 7)
            {
                pictureBox1.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\q7.gif";
                txtQuestion.Text = "7. Geçmişte çok fazla hayal kırıklığına uğradın mı?";
                btn1.Text = "Ne yazık ki evet...";
                btn2.Text = "Çok değil...";
                btn3.Text = "Hayır";
                btn4.Text = "Fazlasıyla";
                btn5.Text = "Ne evet nede hayır";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            if (question == 8)
            {
                pictureBox1.ImageLocation = @"D:\GitHub\workshop-development\desktop-psychological-analysis\images\q8.gif";
                txtQuestion.Text = "8. Son olarak, bu hayatta aşk diye bir şeyin olduğuna inanıyor musun?";
                btn1.Text = "Evet, bir gün gerçek aşkımla karşılaşacağıma inanıyorum...";
                btn2.Text = "Bazen inanıyor bazen de inanmıyorum.";
                btn3.Text = "Aşk diye bir şey yok...";
                btn4.Text = "Fazlasıyla inanıyorum.";
                btn5.Text = "Hiç düşünmedim.";
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            if (question == 9)
            {
                lblTotal.Text = total.ToString();
                if (total >= 8 && total <= 17)
                {
                    MessageBox.Show("Test bitti. Puanınız : " + lblTotal.Text + " " + " Siz Vahşi ve Çılgın birisiniz.Ama her zaman ne yaptığınızın farkındasınız. Hayatınızın kontrolunü kaybetmiyorsunuz.");
                }
                if (total >= 18 && total <= 26)
                {
                    MessageBox.Show("Test bitti. Puanınız : " + lblTotal.Text + " " + " Siz eğlenceli ,arkadaş canlısı ve popüler birisiniz.Cıvıl cıvıl halinizle etrafınıza neşe saçıyorsunuz. Çoğu zaman ikili ilişkilerde uçuk kaçık davranıyorsunuz.");
                }
                if (total >= 27 && total <= 34)
                {
                    MessageBox.Show("Test bitti. Puanınız : " + lblTotal.Text + " " + "Öyle tatlısınız ki sizi sevmememk imkansız. Siz insanların asla kaybetmemek istemeyeceği bir dostsunuz. Kimseyi incitmememk için kendinizi incitirsiniz.");
                }
                if (total >= 35 && total <= 42)
                {
                    MessageBox.Show("Test bitti. Puanınız : " + lblTotal.Text + " " + " Siz iflah olmaz bir romantiksiniz. Gün batımı, kırmızı güller sizin yaşam tarzınız. Bir söz verirseniz o sözü ne olursa olsun yerine getirirsiniz.");
                }

            }
        }
    }
}
