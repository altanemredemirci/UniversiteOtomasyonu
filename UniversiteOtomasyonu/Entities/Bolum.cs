using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Bolum
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        //1-1
        public int FakulteId { get; set; }
        public Fakulte Fakulte { get; set; }

        //1-N
        public List<Ogrenci> Ogrencis { get; set; }

        //1-N
        public List<OgretimGorevlisi> OgretimGorevlisis { get; set; }

        //1-N
        public List<Ders> Dersler { get; set; }
    }
}
