namespace desktop_music_player
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMusicAdd = new System.Windows.Forms.Button();
            this.btnMusicDelete = new System.Windows.Forms.Button();
            this.btnMusicPause = new System.Windows.Forms.Button();
            this.btnMusicNext = new System.Windows.Forms.Button();
            this.btnMusicBack = new System.Windows.Forms.Button();
            this.listBoxListe = new System.Windows.Forms.ListBox();
            this.listBoxUrl = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnMuteOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(5, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(640, 44);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnMusicAdd
            // 
            this.btnMusicAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMusicAdd.Location = new System.Drawing.Point(138, 276);
            this.btnMusicAdd.Name = "btnMusicAdd";
            this.btnMusicAdd.Size = new System.Drawing.Size(89, 34);
            this.btnMusicAdd.TabIndex = 1;
            this.btnMusicAdd.Text = "Müzik Ekle";
            this.btnMusicAdd.UseVisualStyleBackColor = false;
            this.btnMusicAdd.Click += new System.EventHandler(this.btnMusicAdd_Click);
            // 
            // btnMusicDelete
            // 
            this.btnMusicDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMusicDelete.Location = new System.Drawing.Point(533, 276);
            this.btnMusicDelete.Name = "btnMusicDelete";
            this.btnMusicDelete.Size = new System.Drawing.Size(104, 34);
            this.btnMusicDelete.TabIndex = 2;
            this.btnMusicDelete.Text = "Müzik Listesini Sil";
            this.btnMusicDelete.UseVisualStyleBackColor = false;
            this.btnMusicDelete.Click += new System.EventHandler(this.btnMusicDelete_Click);
            // 
            // btnMusicPause
            // 
            this.btnMusicPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMusicPause.Location = new System.Drawing.Point(423, 276);
            this.btnMusicPause.Name = "btnMusicPause";
            this.btnMusicPause.Size = new System.Drawing.Size(104, 34);
            this.btnMusicPause.TabIndex = 3;
            this.btnMusicPause.Text = "Müziği Durdur";
            this.btnMusicPause.UseVisualStyleBackColor = false;
            this.btnMusicPause.Click += new System.EventHandler(this.btnMusicPause_Click);
            // 
            // btnMusicNext
            // 
            this.btnMusicNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMusicNext.Location = new System.Drawing.Point(9, 276);
            this.btnMusicNext.Name = "btnMusicNext";
            this.btnMusicNext.Size = new System.Drawing.Size(56, 34);
            this.btnMusicNext.TabIndex = 4;
            this.btnMusicNext.Text = ">>>";
            this.btnMusicNext.UseVisualStyleBackColor = false;
            this.btnMusicNext.Click += new System.EventHandler(this.btnMusicNext_Click);
            // 
            // btnMusicBack
            // 
            this.btnMusicBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMusicBack.Location = new System.Drawing.Point(73, 276);
            this.btnMusicBack.Name = "btnMusicBack";
            this.btnMusicBack.Size = new System.Drawing.Size(60, 34);
            this.btnMusicBack.TabIndex = 5;
            this.btnMusicBack.Text = "<<<";
            this.btnMusicBack.UseVisualStyleBackColor = false;
            this.btnMusicBack.Click += new System.EventHandler(this.btnMusicBack_Click);
            // 
            // listBoxListe
            // 
            this.listBoxListe.FormattingEnabled = true;
            this.listBoxListe.Location = new System.Drawing.Point(12, 316);
            this.listBoxListe.Name = "listBoxListe";
            this.listBoxListe.Size = new System.Drawing.Size(300, 186);
            this.listBoxListe.TabIndex = 6;
            this.listBoxListe.SelectedIndexChanged += new System.EventHandler(this.listBoxListe_SelectedIndexChanged);
            // 
            // listBoxUrl
            // 
            this.listBoxUrl.FormattingEnabled = true;
            this.listBoxUrl.Location = new System.Drawing.Point(339, 316);
            this.listBoxUrl.Name = "listBoxUrl";
            this.listBoxUrl.Size = new System.Drawing.Size(300, 186);
            this.listBoxUrl.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClose.Location = new System.Drawing.Point(328, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Müziği Kapat";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlay.Location = new System.Drawing.Point(233, 276);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(89, 34);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Müziği Oynat";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMute.Location = new System.Drawing.Point(9, 236);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(60, 34);
            this.btnMute.TabIndex = 10;
            this.btnMute.Text = "<<>>";
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnMuteOpen
            // 
            this.btnMuteOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMuteOpen.Location = new System.Drawing.Point(73, 236);
            this.btnMuteOpen.Name = "btnMuteOpen";
            this.btnMuteOpen.Size = new System.Drawing.Size(60, 34);
            this.btnMuteOpen.TabIndex = 11;
            this.btnMuteOpen.Text = "<>";
            this.btnMuteOpen.UseVisualStyleBackColor = false;
            this.btnMuteOpen.Click += new System.EventHandler(this.btnMuteOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMuteOpen);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listBoxUrl);
            this.Controls.Add(this.listBoxListe);
            this.Controls.Add(this.btnMusicBack);
            this.Controls.Add(this.btnMusicNext);
            this.Controls.Add(this.btnMusicPause);
            this.Controls.Add(this.btnMusicDelete);
            this.Controls.Add(this.btnMusicAdd);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "MusicPlayer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMusicAdd;
        private System.Windows.Forms.Button btnMusicDelete;
        private System.Windows.Forms.Button btnMusicPause;
        private System.Windows.Forms.Button btnMusicNext;
        private System.Windows.Forms.Button btnMusicBack;
        private System.Windows.Forms.ListBox listBoxListe;
        private System.Windows.Forms.ListBox listBoxUrl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnMuteOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

