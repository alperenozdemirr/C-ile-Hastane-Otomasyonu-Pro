using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class AppointmentDal
    {
        public void Add(Appointment appointment)
        {
            using (HospitalContext context = new HospitalContext())
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();
            }
        }
    }
}
