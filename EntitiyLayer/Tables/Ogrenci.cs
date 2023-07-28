using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Tables
{
    public class Ogrenci
    {
        [Key]

        public int OgrenciNo { get; set; }




        public string OgrenciAdi { get; set; }

        public string CozulmusOgrenciAdi { get; set; }


        public string TckimlikNo { get; set; }
        public byte[] fotograf { get; set; }



        public string OgrenciSoyad { get; set; }

        public string CozulmusOgrenciSoyad { get; set; }
        public string Cinsiyet { get; set; }

        public Gender StudentGender { get; set; }

        public enum Gender
        {
            Erkek, Kadin
        }


        public string CepNo { get; set; }


        public string Email { get; set; }
        public bool Durum { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int Yas { get; set; }

        public DateTime KayitTarihi { get; set; }

        //public virtual ICollection<Ogrenci_detay> Ogrenci_Detays { get; set; }

        public ICollection<Sınavlar> Sınavlars { get; set; }
        public ICollection<Ogrenci_detay> Ogrenci_detay { get; set; }
        public ICollection<Kur> Kurs { get; set; }
        public ICollection<Veli> Veli { get; set; }
        public ICollection<Devamsızlık> devamsızlıks { get; set; }
        public ICollection<KurOgrenci> KurOgrencis { get; set; }
    }
}
