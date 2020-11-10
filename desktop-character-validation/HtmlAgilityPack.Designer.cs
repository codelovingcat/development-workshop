namespace desktop_character_validation
{
    partial class HtmlAgilityPack
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
            this.btnHtmlAgilityPack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHtmlAgilityPack
            // 
            this.btnHtmlAgilityPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHtmlAgilityPack.Location = new System.Drawing.Point(78, 68);
            this.btnHtmlAgilityPack.Name = "btnHtmlAgilityPack";
            this.btnHtmlAgilityPack.Size = new System.Drawing.Size(148, 38);
            this.btnHtmlAgilityPack.TabIndex = 0;
            this.btnHtmlAgilityPack.Text = "Html Agility Pack";
            this.btnHtmlAgilityPack.UseVisualStyleBackColor = false;
            this.btnHtmlAgilityPack.Click += new System.EventHandler(this.btnHtmlAgilityPack_Click);
            // 
            // HtmlAgilityPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 190);
            this.Controls.Add(this.btnHtmlAgilityPack);
            this.Name = "HtmlAgilityPack";
            this.Text = "Karakter Doğrulama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHtmlAgilityPack;
    }
}

