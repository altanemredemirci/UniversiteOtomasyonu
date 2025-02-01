using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Kullanici
    {
        public int Id { get; set; }

        [StringLength(11)]
        [MinLength(11)]
        public string TC { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Yetki { get; set; }
    }
}
