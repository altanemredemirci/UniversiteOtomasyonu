using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteOtomasyonu.Entities
{
    internal class Ogrenci
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Ad { get; set; }

        [StringLength(30)]
        public string Soyad { get; set; }

        [StringLength(11)]
        [MinLength(11)]
        public string TC { get; set; }

        [StringLength(5)]
        public string Cinsiyet { get; set; }

        [DataType(DataType.EmailAddress)]
        [MinLength(3)]
        public string Email { get; set; }

        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }


        public List<Notlar> Notlar { get; set; }

    }
}
