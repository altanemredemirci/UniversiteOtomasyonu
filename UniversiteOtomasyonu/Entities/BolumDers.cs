using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class BolumDers
    {
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }


        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
