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
    public partial class AcilVeri : Form
    {
        public AcilVeri()
        {
            InitializeComponent();
        }
        AcilVeriDal _acilVeriDal = new AcilVeriDal();
        private void AcilVeri_Load(object sender, EventArgs e)
        {
            GetList();
            Tedavi();
        }
        void GetList()
        {
            using (HospitalContext context = new HospitalContext())
            {
                dgwAcil.DataSource = context.Emergencies.ToList();
            }
        }
        void Tedavi()
        {
            cbxTedavi.Items.Add("İstirahat");
            cbxTedavi.Items.Add("Hastane Müşade");
            cbxTedavi.Items.Add("Ameliyat");
            cbxTedavi.Items.Add("Hastane Acil Nakil");
            cbxTedavi.Items.Add("Alçı Alınma");
        }
        private void btnMuayne_Click(object sender, EventArgs e)
        {
            _acilVeriDal.Update(new Emergency { 
            id = Convert.ToInt32(dgwAcil.CurrentRow.Cells[0].Value),
            HastaAdiSoyadi = tbxAdSoyad.Text,
            Tc = tbxTc.Text,
            DoktorAdi = tbxDoktor.Text,
            Cinsiyet = tbxCinsiyet.Text,
            HastalikTanisi = tbxTani.Text,
            Recete = tbxRecete.Text,
            Tedeviyontemi = cbxTedavi.Text,
            GirisCinsi = tbxGiriscinsi.Text

            });
            GetList();
        }
        private void dgwAcil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSiraNo.Text = dgwAcil.CurrentRow.Cells[0].Value.ToString();
            tbxAdSoyad.Text = dgwAcil.CurrentRow.Cells[1].Value.ToString();
            tbxTc.Text = dgwAcil.CurrentRow.Cells[2].Value.ToString();
            tbxDoktor.Text = dgwAcil.CurrentRow.Cells[3].Value.ToString();
            tbxCinsiyet.Text = dgwAcil.CurrentRow.Cells[4].Value.ToString();
            tbxTani.Text = dgwAcil.CurrentRow.Cells[5].Value.ToString();
            tbxRecete.Text = dgwAcil.CurrentRow.Cells[6].Value.ToString();
            cbxTedavi.Text = dgwAcil.CurrentRow.Cells[7].Value.ToString();
            tbxGiriscinsi.Text = dgwAcil.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
