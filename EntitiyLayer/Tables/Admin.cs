using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Tables;

namespace EntityLayer.Tables
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string Kullanici { get; set; }
        public int Sifre { get; set; }
        public string Rol { get; set; }
        public string Personel_Sube_Adı { get; set; }

    }
}
