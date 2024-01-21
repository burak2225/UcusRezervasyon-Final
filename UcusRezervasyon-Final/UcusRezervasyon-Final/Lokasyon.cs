using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusRezervasyon_Final
{
    internal class Lokasyon : BaseEntity
    {
        public string Sehir {  get; set; }
        public string Ulke { get; set; }
        public string Havalimani { get; set; }

    }
}
