namespace WindowsFormsApp6
{
    partial class Form2
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
            this.lbl_kazanma = new System.Windows.Forms.Label();
            this.lbl_kazanma_sayi = new System.Windows.Forms.Label();
            this.lbl_kaybetme = new System.Windows.Forms.Label();
            this.lbl_kaybetme_sayi = new System.Windows.Forms.Label();
            this.lbl_oran = new System.Windows.Forms.Label();
            this.lbl_oran_deger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_kazanma
            // 
            this.lbl_kazanma.AutoSize = true;
            this.lbl_kazanma.Location = new System.Drawing.Point(189, 80);
            this.lbl_kazanma.Name = "lbl_kazanma";
            this.lbl_kazanma.Size = new System.Drawing.Size(84, 13);
            this.lbl_kazanma.TabIndex = 0;
            this.lbl_kazanma.Text = "Kazanma Sayısı:";
            this.lbl_kazanma.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_kazanma_sayi
            // 
            this.lbl_kazanma_sayi.AutoSize = true;
            this.lbl_kazanma_sayi.Location = new System.Drawing.Point(296, 80);
            this.lbl_kazanma_sayi.Name = "lbl_kazanma_sayi";
            this.lbl_kazanma_sayi.Size = new System.Drawing.Size(0, 13);
            this.lbl_kazanma_sayi.TabIndex = 1;
            // 
            // lbl_kaybetme
            // 
            this.lbl_kaybetme.AutoSize = true;
            this.lbl_kaybetme.Location = new System.Drawing.Point(189, 114);
            this.lbl_kaybetme.Name = "lbl_kaybetme";
            this.lbl_kaybetme.Size = new System.Drawing.Size(87, 13);
            this.lbl_kaybetme.TabIndex = 2;
            this.lbl_kaybetme.Text = "Kaybetme Sayısı:";
            this.lbl_kaybetme.Click += new System.EventHandler(this.lbl_kaybetme_Click);
            // 
            // lbl_kaybetme_sayi
            // 
            this.lbl_kaybetme_sayi.AutoSize = true;
            this.lbl_kaybetme_sayi.Location = new System.Drawing.Point(296, 114);
            this.lbl_kaybetme_sayi.Name = "lbl_kaybetme_sayi";
            this.lbl_kaybetme_sayi.Size = new System.Drawing.Size(0, 13);
            this.lbl_kaybetme_sayi.TabIndex = 3;
            // 
            // lbl_oran
            // 
            this.lbl_oran.AutoSize = true;
            this.lbl_oran.Location = new System.Drawing.Point(192, 153);
            this.lbl_oran.Name = "lbl_oran";
            this.lbl_oran.Size = new System.Drawing.Size(33, 13);
            this.lbl_oran.TabIndex = 4;
            this.lbl_oran.Text = "Oran:";
            // 
            // lbl_oran_deger
            // 
            this.lbl_oran_deger.AutoSize = true;
            this.lbl_oran_deger.Location = new System.Drawing.Point(241, 153);
            this.lbl_oran_deger.Name = "lbl_oran_deger";
            this.lbl_oran_deger.Size = new System.Drawing.Size(0, 13);
            this.lbl_oran_deger.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_oran_deger);
            this.Controls.Add(this.lbl_oran);
            this.Controls.Add(this.lbl_kaybetme_sayi);
            this.Controls.Add(this.lbl_kaybetme);
            this.Controls.Add(this.lbl_kazanma_sayi);
            this.Controls.Add(this.lbl_kazanma);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_kazanma;
        public System.Windows.Forms.Label lbl_kazanma_sayi;
        public System.Windows.Forms.Label lbl_kaybetme;
        public System.Windows.Forms.Label lbl_kaybetme_sayi;
        public System.Windows.Forms.Label lbl_oran;
        public System.Windows.Forms.Label lbl_oran_deger;
    }
}