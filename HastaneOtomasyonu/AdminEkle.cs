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
    public partial class AdminEkle : Form
    {
        public AdminEkle()
        {
            InitializeComponent();
        }
        AdminDal _adminDal = new AdminDal();
        private void AdminEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxKullanici.Text == "" || tbxAdSoyad.Text == "" || tbxSifre.Text == "" || tbxTekrarSifre.Text == "")
                {
                    lblDurum.Text = "Boş Yer Bırakmayınız!\nKayıt Başarısız";
                    lblDurum.ForeColor = Color.Red;
                }
                else
                {
                    if (tbxSifre.Text == tbxTekrarSifre.Text)
                    {
                        _adminDal.Add(new Manager
                        {
                            Kullanici_ad = tbxKullanici.Text,
                            AdSoyadi = tbxAdSoyad.Text,
                            Sifre = tbxSifre.Text
                        });
                        lblDurum.Text = "Kayıt Başarılı\nBaşarılı Görevler Dilerim...";
                        lblDurum.ForeColor = Color.ForestGreen;
                        MessageBox.Show("Kayıt Edilmiştir");
                    }
                    else
                    {
                        lblDurum.Text = "HATA! Şifreler Uyuşmuyor";
                        lblDurum.ForeColor = Color.Red;

                    }

                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("HATA! Veri Tabanı Bağlantısı Yok");
            }
            
            
        }
    }
}
