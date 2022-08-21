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
    public partial class RandevuMuayne : Form
    {
        public RandevuMuayne()
        {
            InitializeComponent();
        }
        MuayneDal _muayneDal = new MuayneDal();
        void Tedavi()
        {
            cbxTedavi.Items.Add("İstirahat");
            cbxTedavi.Items.Add("Hastane Müşade");
            cbxTedavi.Items.Add("Ameliyat");
            cbxTedavi.Items.Add("Hastane Acil Nakil");
            cbxTedavi.Items.Add("Alçı Alınma");
        }
        void GetList()
        {
            using (HospitalContext context = new HospitalContext())
            {
                dgwRandevu.DataSource = context.Appointments.ToList();
            }
        }
        private void RandevuMuayne_Load(object sender, EventArgs e)
        {
            GetList();
            Tedavi();
        }

        private void dgwRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSiraNo.Text = dgwRandevu.CurrentRow.Cells[0].Value.ToString();
            tbxAdSoyad.Text = dgwRandevu.CurrentRow.Cells[1].Value.ToString();
            tbxTc.Text = dgwRandevu.CurrentRow.Cells[2].Value.ToString();
            tbxRandevusaati.Text = dgwRandevu.CurrentRow.Cells[3].Value.ToString();
            tbxBirim.Text = dgwRandevu.CurrentRow.Cells[4].Value.ToString();
            tbxDoktor.Text = dgwRandevu.CurrentRow.Cells[5].Value.ToString();
            tbxCinsiyet.Text = dgwRandevu.CurrentRow.Cells[6].Value.ToString();
            tbxRecete.Text = dgwRandevu.CurrentRow.Cells[7].Value.ToString();
            cbxTedavi.Text = dgwRandevu.CurrentRow.Cells[8].Value.ToString();
            tbxTani.Text = dgwRandevu.CurrentRow.Cells[9].Value.ToString();
            tbxGiriscinsi.Text = dgwRandevu.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnMuayne_Click(object sender, EventArgs e)
        {
            _muayneDal.Update(new Appointment
            {
                Id = Convert.ToInt32(dgwRandevu.CurrentRow.Cells[0].Value),
                AdSoyad = tbxAdSoyad.Text,
                Tc = tbxTc.Text,
                RandevuSaat = tbxRandevusaati.Text,
                Birim = tbxBirim.Text,
                DoktorAdi = tbxDoktor.Text,
                Cinsiyet = tbxCinsiyet.Text,
                Recete = tbxRecete.Text,
                TedaviYontemi = cbxTedavi.Text,
                HastalikTanisi = tbxTani.Text,
                GirisCinsi = tbxGiriscinsi.Text
            });
             

            GetList();
        }
    }
}
