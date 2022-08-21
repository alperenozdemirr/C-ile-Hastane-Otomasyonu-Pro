using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
   public class Appointment
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Tc { get; set; }
        public string RandevuSaat { get; set; }
        public string Birim { get; set; }
        public string DoktorAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string Recete { get; set; }
        public string TedaviYontemi { get; set; }
        public string HastalikTanisi { get; set; }
        public string GirisCinsi { get; set; }
    }
}
