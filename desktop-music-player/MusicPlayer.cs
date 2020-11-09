using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_music_player
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void btnMusicAdd_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                listBoxListe.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBoxUrl.Items.Add(openFileDialog1.FileNames[i].ToString());
               
            }
            
        }

        private void listBoxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUrl.SelectedIndex = listBoxListe.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBoxUrl.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnMusicPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnMusicDelete_Click(object sender, EventArgs e)
        {
            listBoxListe.Items.Clear();
            listBoxUrl.Items.Clear();
        }

        private void btnMusicNext_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 10;
        }

        private void btnMusicBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 10;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = true;
        }

        private void btnMuteOpen_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = false;
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            pictureBox1.ImageLocation = @"D:\Git-Github\development-workshop\desktop-music-player\image\giphy.gif";
        }
    }
}
