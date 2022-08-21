using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class AcilVeriDal
    {
        public void Update(Emergency emergency)
        {
            using (HospitalContext context = new HospitalContext())
            {
                var entity = context.Entry(emergency);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
           
        }
    }
}
