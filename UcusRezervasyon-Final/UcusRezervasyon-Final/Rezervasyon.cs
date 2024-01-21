using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusRezervasyon_Final
{
    internal class Rezervasyon : BaseEntity    
    {
        public Ucus UcusBilgisi {  get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public int Yas {  get; set; }

        public bool RezervasyonYap() {
            if (UcusBilgisi.UcakBilgisi.Kapasite > 0)
            {
                UcusBilgisi.UcakBilgisi.Kapasite--;
                Console.WriteLine("Rezervasyon başarıyla yapıldı.");
                return true;
            }
            else
            {
                Console.WriteLine("Üzgünüz, uçakta yeterli boş koltuk yok.");
                return false;
            }
        }
    }
}
