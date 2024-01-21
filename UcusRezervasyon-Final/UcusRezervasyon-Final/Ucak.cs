using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusRezervasyon_Final
{
    internal class Ucak : BaseEntity
    {
       public string Model { get; set; }
       public string Marka { get; set; }
       public string SeriNo { get; set; }
       public int Kapasite { get; set; }
    
    
    }
    
}
