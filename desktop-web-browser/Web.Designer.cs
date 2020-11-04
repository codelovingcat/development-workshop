namespace desktop_web_browser
{
    partial class Web
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn4.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(6, 289);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(123, 65);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "HAVA DURUMU";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Wheat;
            this.btn3.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(6, 218);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(123, 65);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "Bi FILM";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn2.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(6, 147);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(123, 65);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "TURKHIS AIRLINES";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(135, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(653, 433);
            this.webBrowser1.TabIndex = 7;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn1.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(6, 76);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 65);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "PGSUS AIRLINES";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn1);
            this.Name = "Web";
            this.Text = "Web Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn1;
    }
}

