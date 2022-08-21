using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class DoktorDal
    {
        public void Add(Doctr doctr)
        {
            using(HospitalContext context= new HospitalContext())
            {
                context.Docktrs.Add(doctr);
                context.SaveChanges();
            }
        }
    }
}
