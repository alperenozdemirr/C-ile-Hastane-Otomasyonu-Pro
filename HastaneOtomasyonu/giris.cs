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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        Randevu randevu = new Randevu();
        PasswordDoktor Doktor = new PasswordDoktor();
        kayit Kayit = new kayit();
        Acilkayit acil = new Acilkayit();
        AdminPassword admin = new AdminPassword();
        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            randevu.ShowDialog();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            Doktor.ShowDialog();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            Kayit.ShowDialog();
        }

        private void btnAcil_Click(object sender, EventArgs e)
        {
            acil.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin.ShowDialog();
        }
    }
}
