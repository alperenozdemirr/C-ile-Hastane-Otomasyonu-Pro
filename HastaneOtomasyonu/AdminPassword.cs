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
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
        }
        AdminGiris giris = new AdminGiris();
        private void btnOkey_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxKullanici.Text =="" || tbxPassword.Text=="")
                {
                    lblDurum.Text = "Boş Yer Bırakmayınız!";
                    lblDurum.ForeColor = Color.ForestGreen;
                }
                else
                {
                    if (kullanicidogrula(tbxKullanici.Text, tbxPassword.Text))
                    {
                        lblDurum.Text = "Giriş Başarılı";
                        lblDurum.ForeColor = Color.ForestGreen;
                        giris.ShowDialog();
                    }
                    else
                    {
                        lblDurum.Text = "Şifreyi Kontrol Ediniz!";
                        lblDurum.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("HATA!!!");
            }
        }
        private bool kullanicidogrula(string kAdi, string kParola)
        {
            HospitalContext context = new HospitalContext();
            var sorgu = from p in context.Managers
                        where p.Kullanici_ad == kAdi
                         && p.Sifre == kParola
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else { tbxPassword.PasswordChar = '*'; }
        }
        private void AdminPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
