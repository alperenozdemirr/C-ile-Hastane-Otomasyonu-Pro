using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class HospitalRegisterDal
    {
        public void Add(HospitalRegister hospitalRegister)
        {
            using(HospitalContext context=new HospitalContext())
            {
                context.HospitalRegisters.Add(hospitalRegister);
                context.SaveChanges();
            }
        }
    }
}
