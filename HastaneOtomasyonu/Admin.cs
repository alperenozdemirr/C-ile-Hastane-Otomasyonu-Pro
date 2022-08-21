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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
           
            using (HospitalContext context = new HospitalContext())
            {
                dgwRandevu.DataSource = context.Appointments.ToList();
            }

            using (HospitalContext context = new HospitalContext())
            {
                dgwKayit.DataSource = context.HospitalRegisters.ToList();
            }

            using (HospitalContext context = new HospitalContext())
            {
                dgwAcil.DataSource = context.Emergencies.ToList();
            }
            using(HospitalContext context=new HospitalContext())
            {
                dgwAdmin.DataSource = context.Managers.ToList();
            }
            using (HospitalContext context = new HospitalContext())
            {
                dgwDoktor.DataSource = context.Docktrs.ToList();
            }
        }   
    }
}
