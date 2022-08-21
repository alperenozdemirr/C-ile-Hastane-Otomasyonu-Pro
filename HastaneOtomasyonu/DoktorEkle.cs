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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }
        DoktorDal _doktorDal = new DoktorDal();

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            _doktorDal.Add(new Doctr
            {
                AdSoyad = tbxAdSoyad.Text,
                Sifre = tbxSifre.Text,
                Tc = tbxKimlik.Text,
                iban = tbxiban.Text,
                Polikinik = tbxPolikinik.Text
            });
            Polikinik();
        }
        void Polikinik()
        {
            tbxPolikinik.Items.Clear();
            tbxPolikinik.Items.Add("Göğüs Hastalıkları");
            tbxPolikinik.Items.Add("Kulak Burun Boğaz Hastalıkları");
            tbxPolikinik.Items.Add("Göz Hastalıkları");
            tbxPolikinik.Items.Add("Çocuk Hastalıkları");
            tbxPolikinik.Items.Add("Beslenme Ve Diyet Hastalıkları");
            tbxPolikinik.Items.Add("Çocuk Cerrahisi Hastalıkları");

        }
        private void btnOkey_Click(object sender, EventArgs e)
        {
            if (tbxAdSoyad.Text==""||tbxiban.Text==""||tbxKimlik.Text==""
                ||tbxPolikinik.Text==""||tbxSifre.Text==""||tbxTekrarSifre.Text=="")
            {
                lblDurum.Text = "Boş Yer Bırakmayınız!\nKayıt Başarısız";
                lblDurum.ForeColor = Color.Red;
            }
            else
            {
                if (tbxSifre.Text == tbxTekrarSifre.Text)
                {
                    _doktorDal.Add(new Doctr
                    {
                        AdSoyad = tbxAdSoyad.Text,
                        Sifre = tbxSifre.Text,
                        Tc = tbxKimlik.Text,
                        iban = tbxiban.Text,
                        Polikinik = tbxPolikinik.Text
                    });
                    lblDurum.Text = "Kayıt Onaylandı";
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
    }
}
