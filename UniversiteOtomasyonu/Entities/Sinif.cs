using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
