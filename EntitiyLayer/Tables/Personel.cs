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
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        [Required]
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        //  public Sube Subes { get; set; }

        public byte[] fotograf { get; set; }
        [ForeignKey(name: "Sube")]
        public int Sube_Id { get; set; }
        public Sube Sube { get; set; }


    }
}
