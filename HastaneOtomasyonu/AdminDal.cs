using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HastaneOtomasyonu
{
    public class AdminDal
    {
        public void Add(Manager manager)
        {
            using(HospitalContext context = new HospitalContext())
            {
                context.Managers.Add(manager);
                context.SaveChanges();
            }
        }
    }
}
