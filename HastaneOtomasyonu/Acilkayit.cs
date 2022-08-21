using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Acilkayit : Form
    {
        public Acilkayit()
        {
            InitializeComponent();
        }
        EmergencyDal _emergencyDal = new EmergencyDal();
         void cinsiyetler()
        {
            cbxCinsiyet.Items.Add("Erkek");
            cbxCinsiyet.Items.Add("Kadın");
            cbxCinsiyet.Items.Add("Cinsiyetsiz");
        }
        string gecici = "-";
        void Doktorlar()
        {
            //girilip cıkılıdıgında sürekli Ekleme Yapmasın diye Clear kullandım
            cbxDoktorAd.Items.Clear();
            cbxDoktorAd.Items.Add("Prof.Dr.Fatih Muhammet Apaydın");
            cbxDoktorAd.Items.Add("Doç.Dr. Alp Eren Özdemir");
            cbxDoktorAd.Items.Add("Dr. Arda Katırcıoğlu");
            cbxDoktorAd.Items.Add("Bekir Yalçın");
            cbxDoktorAd.Items.Add("Dr. Ali Savaş");
        }
        private void Acil_Load(object sender, EventArgs e)
        {
            cinsiyetler();
            Doktorlar();
        }
        // veri tabanına acilden girildigini belirmek amaçlı hocam
        string Giris = "Acil Girişi";
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxAdSoyad.Text=="" || tbxTc.Text=="" || cbxCinsiyet.Text=="" || cbxDoktorAd.Text=="")
                {
                    lblDurum.Text = "Lütfen Boş Yer Bırakmayınız!!!";
                    lblDurum.ForeColor = Color.Red;
                }
                else
                {
                    _emergencyDal.Add(new Emergency
                    {
                        HastaAdiSoyadi = tbxAdSoyad.Text,
                        Tc = tbxTc.Text,
                        Cinsiyet = cbxCinsiyet.Text,
                        DoktorAdi = cbxDoktorAd.Text,
                        HastalikTanisi = gecici,
                        Recete = gecici,
                        Tedeviyontemi = gecici,
                        GirisCinsi = Giris
                    });
                    lblDurum.Text = "İşlem Başarılı";
                    lblDurum.ForeColor = Color.ForestGreen;
                    MessageBox.Show("Sıraya Eklendi");
                }  
            }
            catch(Exception exception)
            {
                MessageBox.Show("HATA! Veri Taban Bağlantısında Bir Problem var !!!");
            }
        }
        private void tbxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
