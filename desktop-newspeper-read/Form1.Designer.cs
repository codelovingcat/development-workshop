namespace desktop_newspeper_read
{
    partial class Form1
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
            this.btnhaber = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listNews = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhaber
            // 
            this.btnhaber.BackColor = System.Drawing.Color.Turquoise;
            this.btnhaber.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhaber.Location = new System.Drawing.Point(181, 0);
            this.btnhaber.Name = "btnhaber";
            this.btnhaber.Size = new System.Drawing.Size(117, 43);
            this.btnhaber.TabIndex = 7;
            this.btnhaber.Text = "Haber İçerik";
            this.btnhaber.UseVisualStyleBackColor = false;
            this.btnhaber.Click += new System.EventHandler(this.btnhaber_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClear.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(304, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 43);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listNews
            // 
            this.listNews.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listNews.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listNews.FormattingEnabled = true;
            this.listNews.ItemHeight = 22;
            this.listNews.Location = new System.Drawing.Point(5, 49);
            this.listNews.Name = "listNews";
            this.listNews.Size = new System.Drawing.Size(1281, 444);
            this.listNews.TabIndex = 5;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRead.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRead.Location = new System.Drawing.Point(78, 0);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(97, 43);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Haber Oku";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 499);
            this.Controls.Add(this.btnhaber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listNews);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Gazete Haberleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnhaber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listNews;
        private System.Windows.Forms.Button btnRead;
    }
}

