using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Borc
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(name: "Veli")]
        public int Veli_Id { get; set; }

        public Veli Veli { get; set; }
        [ForeignKey(name: "Kur")]
        public int KurId { get; set; }

        public Kur Kur { get; set; }
        [ForeignKey(name: "Ogrenci")]
        public int OgrenciNo { get; set; }

        public Ogrenci ogrenci { get; set; }

        public double guncelborc { get; set; }
        public DateTime borctarihi { get; set; }
        public double toplamborc { get; set; }
        [DefaultValue(false)]
        public bool faturaDurumu { get; set; }

    }
}