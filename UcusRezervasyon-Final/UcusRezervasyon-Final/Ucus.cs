using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusRezervasyon_Final
{
    internal class Ucus : BaseEntity
    {
        public Lokasyon Lokasyon;
        public DateTime Tarih;
        public Ucak UcakBilgisi;
        public bool Aktif;

       
    }
}
