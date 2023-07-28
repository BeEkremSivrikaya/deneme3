using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Fatura
    {
        [Key]
        public int fatura_no { get; set; }


        public string Seri_No { get; set; }
        public int Sıra_No { get; set; }
        public int Sube_No { get; set; }
        public int Islem_Tutarı { get; set; }
        public int Kdv_Oranı { get; set; }
        public int Toplam_Tutar { get; set; }
        public int Islem_No { get; set; }
        public DateTime Fatura_Tarihi { get; set; }
        public int Onay_Kodu { get; set; }

        public string Fatura_Tipi { get; set; }

        public string Firma_Adi { get; set; }
        public string Vergi_No { get; set; }
        public string Vergi_Dairesi_Adi { get; set; }

        public string Birey_Adi { get; set; }
        public string Birey_Soyadi { get; set; }
        public string Birey_Tc { get; set; }


        public ICollection<FaturaOdemeler> Faturalar_No { get; set; }
    }
}
