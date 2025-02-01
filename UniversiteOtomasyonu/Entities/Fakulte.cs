using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Fakulte
    {
        public int Id { get; set; }
        public string Ad { get; set; }


        //1-N
        public List<Bolum> Bolums { get; set; }
    }
}
