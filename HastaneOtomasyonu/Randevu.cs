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
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }
        AppointmentDal _appointmentDal = new AppointmentDal();
        private void Randevu_Load(object sender, EventArgs e)
        {
            Doktorlar();
            Birimler();
            Saatler();
            cinsiyetler();
        }
        void cinsiyetler()
        {
            cbxCinsiyet.Items.Clear();
            cbxCinsiyet.Items.Add("Erkek");
            cbxCinsiyet.Items.Add("Kadın");
            cbxCinsiyet.Items.Add("Cinsiyetsiz");
        }
        void Doktorlar()
        {
            cbxDoktorAdi.Items.Clear();
            cbxDoktorAdi.Items.Add("Prof.Dr.Fatih Muhammet Apaydın");
            cbxDoktorAdi.Items.Add("Doç.Dr. Alp Eren Özdemir");
            cbxDoktorAdi.Items.Add("Dr. Arda Katırcıoğlu");
            cbxDoktorAdi.Items.Add("Bekir Yalçın");
            cbxDoktorAdi.Items.Add("Dr. Ali Savaş");
        }
        void Birimler()
        {
            cbxBirim.Items.Clear();
            cbxBirim.Items.Add("Göğüs Hastalıkları");
            cbxBirim.Items.Add("Kulak Burun Boğaz Hastalıkları");
            cbxBirim.Items.Add("Göz Hastalıkları");
            cbxBirim.Items.Add("Çocuk Hastalıkları");
            cbxBirim.Items.Add("Beslenme Ve Diyet Hastalıkları");
             cbxBirim.Items.Add("Çocuk Cerrahisi Hastalıkları");
        }
        void Saatler()
        {
            cbxZaman.Items.Clear();
            cbxZaman.Items.Add("08.30");
            cbxZaman.Items.Add("09.00");
            cbxZaman.Items.Add("09.30");
            cbxZaman.Items.Add("10.00");
            cbxZaman.Items.Add("10.30");
            cbxZaman.Items.Add("11.00");
            cbxZaman.Items.Add("11.30");
            cbxZaman.Items.Add("12.00");
            cbxZaman.Items.Add("12.30");
            cbxZaman.Items.Add("13.00");
            cbxZaman.Items.Add("13.30");
            cbxZaman.Items.Add("14.00");
            cbxZaman.Items.Add("14.30");
            cbxZaman.Items.Add("15.00");
            cbxZaman.Items.Add("15.30");
            cbxZaman.Items.Add("16.00");
            cbxZaman.Items.Add("16.30");
        }
        string gecici = "-";
        // burada Veri tabanında Nasıl giriş yapıldıgı için otomatık giriş belirttim
        string Giriscinsi = "Normal";
        private void btnOkey_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxAdSoyad.Text == "" || tbxTc.Text == "" || cbxBirim.Text == "" 
                    || cbxZaman.Text == "" || cbxDoktorAdi.Text == "")
                {

                    tbxDurum.Text = "Lütfen Boş Yer Bırakırsanız İşleminiz Gerçekleşemez!!!";
                }
                else
                {
                    _appointmentDal.Add(new Appointment
                    {
                        AdSoyad = tbxAdSoyad.Text,
                        Tc = tbxTc.Text,
                        Birim = cbxBirim.Text,
                        RandevuSaat = cbxZaman.Text,
                        DoktorAdi = cbxDoktorAdi.Text,
                        Cinsiyet = cbxCinsiyet.Text,
                        Recete = gecici,
                        TedaviYontemi = gecici,
                        HastalikTanisi = gecici,
                        GirisCinsi = Giriscinsi

                    });
                    tbxDurum.Text = "Akyazı Devlet Hastnesine Randevunuz Onaylanmıştır İyi Günler...";
                    MessageBox.Show("Randevunuz Onaylanmıştır...");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("HATA! Veritaban Bağlantısını Kontrol Ediniz!");
            } 
        }
        private void tbxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
