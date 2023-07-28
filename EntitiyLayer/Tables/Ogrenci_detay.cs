using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Tables;

namespace EntityLayer.Tables
{
    public class Ogrenci_detay
    {


        [Key]

        public int Id { get; set; }
        public string Sinif { get; set; } 
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }

        [ForeignKey(name: "Ogrenci")]
        public int Ogrenci_Id { get; set; }
        public Ogrenci Ogrenci { get; set; }

    }
}
