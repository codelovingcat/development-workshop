namespace desktop_graphic_operations
{
    partial class Graphic
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
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTea = new System.Windows.Forms.Label();
            this.lblHazelnut = new System.Windows.Forms.Label();
            this.lblEgypt = new System.Windows.Forms.Label();
            this.textTea = new System.Windows.Forms.TextBox();
            this.textHazelnut = new System.Windows.Forms.TextBox();
            this.textEgypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnTotal.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTotal.Location = new System.Drawing.Point(172, 143);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(200, 38);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.Text = "Grafik Oluştur";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTea
            // 
            this.lblTea.AutoSize = true;
            this.lblTea.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTea.Location = new System.Drawing.Point(68, 35);
            this.lblTea.Name = "lblTea";
            this.lblTea.Size = new System.Drawing.Size(62, 29);
            this.lblTea.TabIndex = 1;
            this.lblTea.Text = "Çay : ";
            // 
            // lblHazelnut
            // 
            this.lblHazelnut.AutoSize = true;
            this.lblHazelnut.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHazelnut.Location = new System.Drawing.Point(68, 71);
            this.lblHazelnut.Name = "lblHazelnut";
            this.lblHazelnut.Size = new System.Drawing.Size(85, 29);
            this.lblHazelnut.TabIndex = 2;
            this.lblHazelnut.Text = "Fındık : ";
            // 
            // lblEgypt
            // 
            this.lblEgypt.AutoSize = true;
            this.lblEgypt.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgypt.Location = new System.Drawing.Point(68, 108);
            this.lblEgypt.Name = "lblEgypt";
            this.lblEgypt.Size = new System.Drawing.Size(75, 29);
            this.lblEgypt.TabIndex = 3;
            this.lblEgypt.Text = "Mısır : ";
            // 
            // textTea
            // 
            this.textTea.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTea.Location = new System.Drawing.Point(172, 31);
            this.textTea.Name = "textTea";
            this.textTea.Size = new System.Drawing.Size(200, 33);
            this.textTea.TabIndex = 4;
            // 
            // textHazelnut
            // 
            this.textHazelnut.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textHazelnut.Location = new System.Drawing.Point(172, 67);
            this.textHazelnut.Name = "textHazelnut";
            this.textHazelnut.Size = new System.Drawing.Size(200, 33);
            this.textHazelnut.TabIndex = 5;
            // 
            // textEgypt
            // 
            this.textEgypt.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEgypt.Location = new System.Drawing.Point(172, 104);
            this.textEgypt.Name = "textEgypt";
            this.textEgypt.Size = new System.Drawing.Size(200, 33);
            this.textEgypt.TabIndex = 6;
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 283);
            this.Controls.Add(this.textEgypt);
            this.Controls.Add(this.textHazelnut);
            this.Controls.Add(this.textTea);
            this.Controls.Add(this.lblEgypt);
            this.Controls.Add(this.lblHazelnut);
            this.Controls.Add(this.lblTea);
            this.Controls.Add(this.btnTotal);
            this.Name = "Graphic";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTea;
        private System.Windows.Forms.Label lblHazelnut;
        private System.Windows.Forms.Label lblEgypt;
        private System.Windows.Forms.TextBox textTea;
        private System.Windows.Forms.TextBox textHazelnut;
        private System.Windows.Forms.TextBox textEgypt;
    }
}

