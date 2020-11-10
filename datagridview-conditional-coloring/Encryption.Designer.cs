namespace datagridview_conditional_coloring
{
    partial class Encryption
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
            this.btnPasswordSolve = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPasswordSolve
            // 
            this.btnPasswordSolve.BackColor = System.Drawing.Color.Purple;
            this.btnPasswordSolve.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPasswordSolve.ForeColor = System.Drawing.Color.White;
            this.btnPasswordSolve.Location = new System.Drawing.Point(403, 101);
            this.btnPasswordSolve.Name = "btnPasswordSolve";
            this.btnPasswordSolve.Size = new System.Drawing.Size(203, 34);
            this.btnPasswordSolve.TabIndex = 11;
            this.btnPasswordSolve.Text = "Şifre Çöz ";
            this.btnPasswordSolve.UseVisualStyleBackColor = false;
            this.btnPasswordSolve.Click += new System.EventHandler(this.btnPasswordSolve_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassword.Location = new System.Drawing.Point(128, 58);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(521, 27);
            this.textBoxPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifreli Metin  : ";
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMetin.Location = new System.Drawing.Point(128, 22);
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(521, 27);
            this.textBoxMetin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Metin : ";
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Thistle;
            this.btnPassword.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPassword.Location = new System.Drawing.Point(179, 101);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(203, 34);
            this.btnPassword.TabIndex = 6;
            this.btnPassword.Text = "Şifrele";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 207);
            this.Controls.Add(this.btnPasswordSolve);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassword);
            this.Name = "Encryption";
            this.Text = "Şifreleme Algoritması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasswordSolve;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPassword;
    }
}

