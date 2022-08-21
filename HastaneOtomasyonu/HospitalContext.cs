using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class HospitalContext:DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<HospitalRegister> HospitalRegisters { get; set; }
        public DbSet<Emergency> Emergencies { get; set; }
        public DbSet<Doctr> Docktrs { get; set; }
        public DbSet<Manager> Managers { get; set; }
        
    }
}
