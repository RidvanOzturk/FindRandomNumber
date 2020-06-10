namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_olus = new System.Windows.Forms.Button();
            this.lbl_sayi_olus = new System.Windows.Forms.Label();
            this.lbl_sayi_gir = new System.Windows.Forms.Label();
            this.txtBox_sayi = new System.Windows.Forms.TextBox();
            this.btn_tahmin_et = new System.Windows.Forms.Button();
            this.lbl_tahmin_sonuc = new System.Windows.Forms.Label();
            this.lbl_ipucu = new System.Windows.Forms.Label();
            this.btn_ipucu = new System.Windows.Forms.Button();
            this.lbl_ipucu_al = new System.Windows.Forms.Label();
            this.lstBox_puan = new System.Windows.Forms.ListBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lbl_yetmis = new System.Windows.Forms.Label();
            this.sonuc_goruntule = new System.Windows.Forms.Button();
            this.lbl_deneme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_olus
            // 
            this.btn_olus.Location = new System.Drawing.Point(89, 56);
            this.btn_olus.Name = "btn_olus";
            this.btn_olus.Size = new System.Drawing.Size(84, 33);
            this.btn_olus.TabIndex = 0;
            this.btn_olus.Text = "Sayı Oluştur";
            this.btn_olus.UseVisualStyleBackColor = true;
            this.btn_olus.Click += new System.EventHandler(this.btn_olus_Click_1);
            // 
            // lbl_sayi_olus
            // 
            this.lbl_sayi_olus.AutoSize = true;
            this.lbl_sayi_olus.Location = new System.Drawing.Point(86, 91);
            this.lbl_sayi_olus.Name = "lbl_sayi_olus";
            this.lbl_sayi_olus.Size = new System.Drawing.Size(0, 13);
            this.lbl_sayi_olus.TabIndex = 1;
            // 
            // lbl_sayi_gir
            // 
            this.lbl_sayi_gir.AutoSize = true;
            this.lbl_sayi_gir.Location = new System.Drawing.Point(86, 178);
            this.lbl_sayi_gir.Name = "lbl_sayi_gir";
            this.lbl_sayi_gir.Size = new System.Drawing.Size(174, 13);
            this.lbl_sayi_gir.TabIndex = 2;
            this.lbl_sayi_gir.Text = "0 İle 100 Arasında Tahmini Sayı Gir:";
            // 
            // txtBox_sayi
            // 
            this.txtBox_sayi.Location = new System.Drawing.Point(89, 203);
            this.txtBox_sayi.Name = "txtBox_sayi";
            this.txtBox_sayi.Size = new System.Drawing.Size(100, 20);
            this.txtBox_sayi.TabIndex = 3;
            // 
            // btn_tahmin_et
            // 
            this.btn_tahmin_et.Location = new System.Drawing.Point(89, 239);
            this.btn_tahmin_et.Name = "btn_tahmin_et";
            this.btn_tahmin_et.Size = new System.Drawing.Size(84, 28);
            this.btn_tahmin_et.TabIndex = 4;
            this.btn_tahmin_et.Text = "Tahmin Et";
            this.btn_tahmin_et.UseVisualStyleBackColor = true;
            this.btn_tahmin_et.Click += new System.EventHandler(this.btn_tahmin_et_Click);
            // 
            // lbl_tahmin_sonuc
            // 
            this.lbl_tahmin_sonuc.AutoSize = true;
            this.lbl_tahmin_sonuc.Location = new System.Drawing.Point(86, 272);
            this.lbl_tahmin_sonuc.Name = "lbl_tahmin_sonuc";
            this.lbl_tahmin_sonuc.Size = new System.Drawing.Size(0, 13);
            this.lbl_tahmin_sonuc.TabIndex = 5;
            // 
            // lbl_ipucu
            // 
            this.lbl_ipucu.AutoSize = true;
            this.lbl_ipucu.Location = new System.Drawing.Point(86, 290);
            this.lbl_ipucu.Name = "lbl_ipucu";
            this.lbl_ipucu.Size = new System.Drawing.Size(0, 13);
            this.lbl_ipucu.TabIndex = 6;
            // 
            // btn_ipucu
            // 
            this.btn_ipucu.Location = new System.Drawing.Point(305, 56);
            this.btn_ipucu.Name = "btn_ipucu";
            this.btn_ipucu.Size = new System.Drawing.Size(92, 33);
            this.btn_ipucu.TabIndex = 7;
            this.btn_ipucu.Text = "İpucu Al";
            this.btn_ipucu.UseVisualStyleBackColor = true;
            this.btn_ipucu.Click += new System.EventHandler(this.btn_ipucu_Click);
            // 
            // lbl_ipucu_al
            // 
            this.lbl_ipucu_al.AutoSize = true;
            this.lbl_ipucu_al.Location = new System.Drawing.Point(86, 157);
            this.lbl_ipucu_al.Name = "lbl_ipucu_al";
            this.lbl_ipucu_al.Size = new System.Drawing.Size(0, 13);
            this.lbl_ipucu_al.TabIndex = 8;
            // 
            // lstBox_puan
            // 
            this.lstBox_puan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstBox_puan.FormattingEnabled = true;
            this.lstBox_puan.Location = new System.Drawing.Point(595, 75);
            this.lstBox_puan.Name = "lstBox_puan";
            this.lstBox_puan.Size = new System.Drawing.Size(143, 160);
            this.lstBox_puan.TabIndex = 9;
            this.lstBox_puan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(89, 121);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(225, 23);
            this.progBar.TabIndex = 10;
            this.progBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbl_yetmis
            // 
            this.lbl_yetmis.AutoSize = true;
            this.lbl_yetmis.Location = new System.Drawing.Point(554, 40);
            this.lbl_yetmis.Name = "lbl_yetmis";
            this.lbl_yetmis.Size = new System.Drawing.Size(0, 13);
            this.lbl_yetmis.TabIndex = 11;
            // 
            // sonuc_goruntule
            // 
            this.sonuc_goruntule.Location = new System.Drawing.Point(626, 272);
            this.sonuc_goruntule.Name = "sonuc_goruntule";
            this.sonuc_goruntule.Size = new System.Drawing.Size(81, 31);
            this.sonuc_goruntule.TabIndex = 12;
            this.sonuc_goruntule.Text = "Sonuç";
            this.sonuc_goruntule.UseVisualStyleBackColor = true;
            this.sonuc_goruntule.Click += new System.EventHandler(this.sonuc_goruntule_Click);
            // 
            // lbl_deneme
            // 
            this.lbl_deneme.AutoSize = true;
            this.lbl_deneme.Location = new System.Drawing.Point(225, 254);
            this.lbl_deneme.Name = "lbl_deneme";
            this.lbl_deneme.Size = new System.Drawing.Size(0, 13);
            this.lbl_deneme.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_deneme);
            this.Controls.Add(this.sonuc_goruntule);
            this.Controls.Add(this.lbl_yetmis);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.lstBox_puan);
            this.Controls.Add(this.lbl_ipucu_al);
            this.Controls.Add(this.btn_ipucu);
            this.Controls.Add(this.lbl_ipucu);
            this.Controls.Add(this.lbl_tahmin_sonuc);
            this.Controls.Add(this.btn_tahmin_et);
            this.Controls.Add(this.txtBox_sayi);
            this.Controls.Add(this.lbl_sayi_gir);
            this.Controls.Add(this.lbl_sayi_olus);
            this.Controls.Add(this.btn_olus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahmin Et Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_olus;
        public System.Windows.Forms.Label lbl_sayi_olus;
        public System.Windows.Forms.Label lbl_sayi_gir;
        public System.Windows.Forms.TextBox txtBox_sayi;
        public System.Windows.Forms.Button btn_tahmin_et;
        public System.Windows.Forms.Label lbl_tahmin_sonuc;
        public System.Windows.Forms.Label lbl_ipucu;
        public System.Windows.Forms.Button btn_ipucu;
        public System.Windows.Forms.Label lbl_ipucu_al;
        public System.Windows.Forms.ListBox lstBox_puan;
        public System.Windows.Forms.ProgressBar progBar;
        public System.Windows.Forms.Label lbl_yetmis;
        private System.Windows.Forms.Button sonuc_goruntule;
        private System.Windows.Forms.Label lbl_deneme;
    }
}

