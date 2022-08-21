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
    public partial class PasswordDoktor : Form
    {
        public PasswordDoktor()
        {
            InitializeComponent();
        }
        Doktor doktor = new Doktor();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else { tbxPassword.PasswordChar = '*'; }
        }
        private void btnOkey_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxKullanici.Text == "" || tbxPassword.Text == "")
                {
                    lblDurum.Text = "Boş Yerleri Doldurun!";
                    lblDurum.ForeColor = Color.Red;
                }
                else
                {
                    if (kullanicidogrula(tbxKullanici.Text, tbxPassword.Text))
                    {
                        lblDurum.Text = "Giriş Başarılı";
                        lblDurum.ForeColor = Color.ForestGreen;
                        doktor.ShowDialog();
                    }
                    else
                    {
                        lblDurum.Text = "Bilgileri Kontrol Ediniz!";
                        lblDurum.ForeColor = Color.Red;
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("HATA!!!");
            }
        }
        private bool kullanicidogrula(string kAdi, string kParola)
        {
            HospitalContext context = new HospitalContext();
            var sorgu = from p in context.Docktrs
                        where p.Tc == kAdi
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
        private void PasswordDoktor_Load(object sender, EventArgs e)
        {
        }
    }
}
