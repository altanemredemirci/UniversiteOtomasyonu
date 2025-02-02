using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        //1-N
        public List<BolumDers> BolumDers { get; set; }


        public List<Notlar> Notlar { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
