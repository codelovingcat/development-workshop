namespace desktop_google_translate
{
    partial class GoogleTranslate
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioBtnEng = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.radioBtnTr = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTranslate.Font = new System.Drawing.Font("Minion Pro SmBd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTranslate.Location = new System.Drawing.Point(204, 192);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(114, 46);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Çevir";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioBtnEng
            // 
            this.radioBtnEng.AutoSize = true;
            this.radioBtnEng.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnEng.Location = new System.Drawing.Point(253, 141);
            this.radioBtnEng.Name = "radioBtnEng";
            this.radioBtnEng.Size = new System.Drawing.Size(95, 26);
            this.radioBtnEng.TabIndex = 2;
            this.radioBtnEng.TabStop = true;
            this.radioBtnEng.Text = "ENG - TR";
            this.radioBtnEng.UseVisualStyleBackColor = true;
            this.radioBtnEng.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(280, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "İngilizce";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox2.Location = new System.Drawing.Point(274, 30);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(260, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // radioBtnTr
            // 
            this.radioBtnTr.AutoSize = true;
            this.radioBtnTr.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnTr.Location = new System.Drawing.Point(12, 141);
            this.radioBtnTr.Name = "radioBtnTr";
            this.radioBtnTr.Size = new System.Drawing.Size(95, 26);
            this.radioBtnTr.TabIndex = 6;
            this.radioBtnTr.TabStop = true;
            this.radioBtnTr.Text = "TR - ENG";
            this.radioBtnTr.UseVisualStyleBackColor = true;
            this.radioBtnTr.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(432, 362);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(93, 34);
            this.webBrowser1.TabIndex = 7;
            // 
            // GoogleTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 283);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.radioBtnTr);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnEng);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnTranslate);
            this.Name = "GoogleTranslate";
            this.Text = "Translate";
            this.Load += new System.EventHandler(this.GoogleTranslate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioBtnEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RadioButton radioBtnTr;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

