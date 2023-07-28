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
    public class Kur
    {
        [Key, Column(Order = 1)]

        public int KayıtId { get; set; }
        public int KurId { get; set; }
        public string KurAdi { get; set; }
        public int süre { get; set; }

        public int kurucreti { get; set; }
        public DateTime BaslangicZamani { get; set; }
        public DateTime KurBitiş { get; set; }


        public bool Durum { get; set; }

        [ForeignKey(name: "YasGrubu")]
        public int YasId { get; set; }
        public YasGrubu Yas { get; set; }


        public ICollection<KurOgrenci> KurOgrencis { get; set; }

        public ICollection<Borc> borc { get; set; }



    }
}