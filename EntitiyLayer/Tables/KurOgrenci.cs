using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class KurOgrenci
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey(name: "Ogrenci")]
        public int Ogrenci_Id { get; set; }
        public Ogrenci Ogrenci { get; set; }

        [ForeignKey(name: "Kur")]
        public int Kur_Id { get; set; }
        public Kur Kur { get; set; }
        public int kurucreti { get; set; }
        public bool başarıdurumu { get; set; }
        public bool mezuniyet_durumu { get; set; }//ogrenci kendi yas gurubundaki son seviyeye geldiğinde kur bitirmeden mezuniyet durumunu bilmek istiyoruz

    }
}