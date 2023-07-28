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
    public class Veli
    {
        [Key]
        public int Veli_Id { get; set; }
        public string TckimlikNo { get; set; }
        public  string  Veli_Ad { get; set; }
        public string Veli_Soyad { get; set; }
        public VeliTipi VelininTipi { get; set; }

        public enum VeliTipi
        {
            Anne,Baba,Anneane,Dede,Hala,Teyze,Amca,Dayi,Abla,Abi
        }
        public string Meslek { get; set; }
        public string Cepno { get; set; }
        public string Eposta { get; set; }
        [ForeignKey(name: "Ogrenci")]
        public int Ogrenci_Id { get; set; }

        public Ogrenci Ogrenci { get; set; }


        public ICollection<Odemeler> Odemelers { get; set; }
        public ICollection<Borc> borcs { get; set; }


    }
    
}
