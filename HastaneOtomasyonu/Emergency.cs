using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class Emergency
    {
        public int id { get; set; }
        public string HastaAdiSoyadi { get; set; }
        public string Tc { get; set; }
        public string Cinsiyet { get; set; }
        public string DoktorAdi { get; set; }
        public string HastalikTanisi { get; set; }
        public string Recete { get; set; }
        public string Tedeviyontemi { get; set; }
        public string GirisCinsi { get; set; }
    }
}
