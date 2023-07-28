
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
    public class Sınavlar
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(name: "Ogrenci")]
        public int Ogrenci_No { get; set; }
        public Ogrenci Ogrenci { get; set; }
  

        [ForeignKey(name: "Kur")]
        public int Kur_Id { get; set; }
        public Kur Kur { get; set; }
        [ForeignKey(name: "SınavKodu")]
        public int SınavKodu { get; set; }
        public SınavTurleri sınavKodu{ get; set; }
        public int BasariNotu { get; set; }
    }
}
