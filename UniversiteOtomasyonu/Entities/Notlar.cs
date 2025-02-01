using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Notlar
    {
        public int Id { get; set; }
        public int Not { get; set; }

        public int DersId { get; set; }
        public Ders Ders { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
