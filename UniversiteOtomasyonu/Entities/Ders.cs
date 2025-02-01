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

        //1-1
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }

        //1-N
        public List<Ogrenci> Ogrencis { get; set; }

        //1-N
        public List<Bolum> Bolums { get; set; }


        public List<Notlar> Notlar { get; set; }
    }
}
