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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        private void Rapor_Load(object sender, EventArgs e)
        {
            using(HospitalContext context =new HospitalContext())
            {
                var randevuSay       = context.Appointments.Count();
                var doktorSayisi     = context.Docktrs.Count();
                var acilKayitSayisi  = context.Emergencies.Count();
                var hastaKayitSayisi = context.HospitalRegisters.Count();
                var adminSayisi      = context.Managers.Count();

                tbxRandevüSayisi.Text = randevuSay.ToString();
                tbxDoktorSayisi.Text  = doktorSayisi.ToString();
                tbxAcilSayisi.Text    = acilKayitSayisi.ToString();
                tbxHastaSayisi.Text   = hastaKayitSayisi.ToString();
                tbxAdminSayisi.Text   = adminSayisi.ToString();
               
                chart1.Series["data"].Points.Add(randevuSay);
                chart1.Series["data"].Points.Add(doktorSayisi);
                chart1.Series["data"].Points.Add(acilKayitSayisi);
                chart1.Series["data"].Points.Add(hastaKayitSayisi);
                chart1.Series["data"].Points.Add(adminSayisi);
            }
            chart1.Series["data"].Points[0].AxisLabel = "Randevular";
            chart1.Series["data"].Points[1].AxisLabel = "Doktorlar";
            chart1.Series["data"].Points[2].AxisLabel = "Aciller";
            chart1.Series["data"].Points[3].AxisLabel = "H.Kayıtlar";
            chart1.Series["data"].Points[4].AxisLabel = "Admin Sayısı";

            chart1.Series["data"].Points[0].Color = Color.Aqua;
            chart1.Series["data"].Points[1].Color = Color.Chocolate;
            chart1.Series["data"].Points[2].Color = Color.Orange;
            chart1.Series["data"].Points[3].Color = Color.RoyalBlue;
            chart1.Series["data"].Points[4].Color = Color.Blue;
            chart1.BackColor = Color.Transparent;
        }
    }
}
