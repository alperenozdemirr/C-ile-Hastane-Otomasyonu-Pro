using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class EmergencyDal
    {
        public void Add(Emergency emergency)
        {
            using (HospitalContext context = new HospitalContext())
            {
                context.Emergencies.Add(emergency);
                context.SaveChanges();
            }
        }
    }
}
