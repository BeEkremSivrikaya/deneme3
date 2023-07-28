
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
    public class Giderler
    {
        [Key]
        public int gdr_No { get; set; }
        [ForeignKey(name: "GiderTurleri")]
        public int GiderTuruKodu { get; set; }
        public GiderTurleri GiderTurleri { get; set; }

        public int Tutar { get; set; }
        
        public DateTime gdr_Tarih { get; set; }
        [ForeignKey(name: "Sube")]
        public int Sube_Id { get; set; }
        public Sube Subes { get; set; }


    }
}
