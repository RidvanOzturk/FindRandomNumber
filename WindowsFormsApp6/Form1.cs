using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int num1;
        int rastgele,rastgele2;
        int listPuan = 100;
        int kazanmaSayisi = 0, kaybetmeSayisi = 0;
        int Deneme_kazan = 1;
        double oran=0;

        Random random = new Random();
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_olus_Click_1(object sender, EventArgs e)
        {
            progBar.Value += 100;
            num1 = random.Next(1, 51);
            lbl_sayi_olus.Text = "0 ile 100 arasında rastgele sayı oluşturuldu.";
            lstBox_puan.Items.Add("Puan Durumu:" + listPuan);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void btn_tahmin_et_Click(object sender, EventArgs e)
        {

            try
            { 
                int val=Convert.ToInt32(txtBox_sayi.Text);
                if (val == num1)
                {
                    lbl_tahmin_sonuc.Text = "Tebrikler doğru bildiniz.\nKazandınız!";
                    kazanmaSayisi++;
                    lbl_deneme.Text = "Kaç denemeden sonra bulundu: " + Deneme_kazan;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("İlk etabı kazandınız. Devam etmek ister misiniz?", "Galibiyet", buttons);
                    if (result == DialogResult.Yes)
                    {
                        DevamEt();
                    }
                    else
                    {
                        SonucGoruntule();
                        this.Close();
                        Application.Exit();
                    }
                }
                else
                {
                    lbl_tahmin_sonuc.Text = "Bilemediniz! Puanınız düştü.";
                    listPuan -= 5;
                    Deneme_kazan++;
                    lstBox_puan.Items.Add("Puan Durumu:" + listPuan);
                    lbl_ipucu.Text = "İpucu aldınız mı?\nNot:Her soru için bir ipucu alınır ve alımında puan değeri 10 düşer.";
                }
                if (listPuan < 80)
                {
                    lbl_yetmis.Text = "Not:70 puanın altına düşersen kaybedeceksin.";
                }
                if (listPuan < 70)
                {
                    kaybetmeSayisi++;
                    Deneme_kazan = 0;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("İlk etabı kaybettiniz. Devam etmek ister misiniz?", "Mağlubiyet", buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        DevamEt();

                    }
                    else
                    {
                        SonucGoruntule();
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen tahmini sayı giriniz:");
            }

            
        }
        public void DevamEt()
        {
            btn_ipucu.Visible = true;
            listPuan = 100;
            progBar.Value = 0;
            lstBox_puan.Items.Clear();
            txtBox_sayi.Clear();
            lbl_ipucu.Text = "";
            lbl_ipucu_al.Text = "";
            lbl_sayi_olus.Text = "";
            lbl_tahmin_sonuc.Text = "";
            lbl_yetmis.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //f3.Close();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void sonuc_goruntule_Click(object sender, EventArgs e)
        {
            SonucGoruntule();
        }
        public void SonucGoruntule()
        {
            if (kazanmaSayisi == 0 && kaybetmeSayisi == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Henüz etap bitmedi. Uygulamayı kapatmak istiyor musun?", "Daha bitirmedin!", buttons, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                oran = kaybetmeSayisi != 0 ? (kazanmaSayisi / kaybetmeSayisi) * 100 : 100;
            }

            f2.lbl_kazanma_sayi.Text = kazanmaSayisi.ToString();
            f2.lbl_kaybetme_sayi.Text = kaybetmeSayisi.ToString();
            f2.lbl_oran_deger.Text = "%" + oran;
            f2.ShowDialog();
        }



        private void btn_ipucu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("İpucu almak 10 puan değeri düşürür. Yine de almak istiyor musunuz?", "İpucu Alımı", buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                rastgele = random.Next(num1 - 10, num1);
                rastgele2 = random.Next(num1, num1 + 10);
                lbl_ipucu_al.Text = string.Concat("İpucu: Sayımız ", (rastgele > 0 ? rastgele : 0), " ile ", rastgele2, " Arasındadır.");
                listPuan -= 10;
                lstBox_puan.Items.Add("Puan Durumu:" + listPuan);
                btn_ipucu.Visible = false;
            }
            else
            {
                
            }

        }
    }
}
