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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        AdminEkle adminEkle = new AdminEkle();
        Admin admin = new Admin();
        DoktorEkle doktorEkle = new DoktorEkle();
        Rapor rapor = new Rapor();
        private void AdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            admin.ShowDialog();
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            adminEkle.ShowDialog();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            doktorEkle.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            rapor.ShowDialog();
        }
    }
}
