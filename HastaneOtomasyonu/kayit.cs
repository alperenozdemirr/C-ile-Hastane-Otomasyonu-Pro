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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        HospitalRegisterDal _hospitalRegisterDal = new HospitalRegisterDal();
        private void kayit_Load(object sender, EventArgs e)
        {
            cinsiyet();
            iller();
        }
         void cinsiyet()
        {
            //ilk başa clear koymamın sebebi girip cıkıldıgında süreklı ekleme yapıyor
            cbxCinsiyet.Items.Clear();
            cbxCinsiyet.Items.Add("Erkek");
            cbxCinsiyet.Items.Add("Kadın");
            cbxCinsiyet.Items.Add("Cinsiyetsiz");
        }
        public void iller()
        {
            cbxİl.Items.Clear();
            cbxİl.Items.Add("Sakarya");
            cbxİl.Items.Add("İstanbul");
            cbxİl.Items.Add("Eskişehir");
            cbxİl.Items.Add("Ankara");
            cbxİl.Items.Add("Adıyaman");
            cbxİl.Items.Add("Kütahya");
            cbxİl.Items.Add("Mersin");
            cbxİl.Items.Add("Muğla");
            cbxİl.Items.Add("Hakkari");
        }
        //Numaradan başka Harf girmesini engelleme için hocam... :D
        private void tbxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxAdSoyad.Text == "" || tbxAnneAdi.Text == "" || tbxBabaAdi.Text == "" || cbxCinsiyet.Text == ""
                    || tbxTel.Text == "" || cbxİl.Text == "" || tbxDogumTarihi.Text == "" || tbxTc.Text == "")
                {
                    lblDurum.Text = "Lütfen Boşlukları Doldurunuz!";
                    lblDurum.ForeColor = Color.Red;
                }
                else
                {
                    _hospitalRegisterDal.Add(new HospitalRegister
                    {
                        AdSoyad = tbxAdSoyad.Text,
                        AnneAdi = tbxAnneAdi.Text,
                        BabaAdi = tbxBabaAdi.Text,
                        Cinsiyet = cbxCinsiyet.Text,
                        Tel = tbxTel.Text,
                        DogumYeri = cbxİl.Text,
                        DogumTarihi = tbxDogumTarihi.Text,
                        Tc = tbxTc.Text
                    });
                    lblDurum.Text = "Kayıt Başarılı!";
                    lblDurum.ForeColor = Color.ForestGreen;
                    MessageBox.Show("Kayıt Edildi!");

                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("HATA! Veri Tabanı Bağlantısını Kontrol Ediniz!!!");
            }
            
           
        }
    }
}
