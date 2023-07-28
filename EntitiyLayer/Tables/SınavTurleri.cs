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
    public class SınavTurleri
    {
        [Key]
        public int sinavkodu { get; set; }
        public string sınavAdi { get; set; }

        public ICollection<Sınavlar> Sınavlars { get; set; }
    }
}
