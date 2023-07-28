using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Sube
    {
        [Key]
        public int Sube_Id { get; set; }
        public string Sube_Adı { get; set; }
        public string Sube_Adres { get; set; }
        //public List<Personel> Personel { get; set; }
        public ICollection<Personel> Personels { get; set; }
        public ICollection<Ogrenci> Ogrencis { get; set; }
        public ICollection<Giderler> Giderlers{ get; set; }
        public ICollection<FaturaOdemeler> FaturaOdemelers { get; set; }
        [ForeignKey(name: "Il")]
        public int Il_Id { get; set; }
        public Il Il { get; set; }
   

    }
}
