
using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Tables
{
    public class Odemeler
    {
        [Key]
        public int odeme_no { get; set; }
        public ICollection<FaturaOdemeler> Odemeler_No { get; set; }
        [ForeignKey(name: "OdemeTurleri")]
        public int odemeTur_Id { get; set; }
        public OdemeTurleri OdemeTurleri { get; set; }

        [ForeignKey(name: "Veli")]

        public int Veli_Id { get; set; }
        public Veli Veli { get; set; }
        public int kalanOdemeMiktari { get; set; }
        public double borçTutarı { get; set; }//bu kur ücreti ile eşit olucak
        public Banka Banka { get; set; }
        public DateTime odeme_tarih { get; set; }
        public int odeme_Tutar { get; set; }//yapılan ödemenin miktarını temsil eder
        public int taksit_sayısı { get; set; }
        public int bakiye { get; set; }//borçtutarı-ödemetutarı

        public int KurId { get; set; }//


    }
}