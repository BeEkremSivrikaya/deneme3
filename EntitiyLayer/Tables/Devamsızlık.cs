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
    public class Devamsızlık
    {
        [Key]
        public int Kayıt_Id { get; set; }
        public int Kur_no { get; set; }
        public bool devamsizlık { get; set; }
        [ForeignKey(name: "Ogrenci")]
        public int OgrenciNo { get; set; }
        public Ogrenci ogrenci { get; set; }

    }
}