using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class MuayneDal
    {
        public void Update(Appointment appointment)
        {
            using(HospitalContext context= new HospitalContext())
            {
                var entity = context.Entry(appointment);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

       
    }
}
