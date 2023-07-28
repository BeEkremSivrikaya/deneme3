using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class GiderTurleri
    {
        [Key]
        public int giderTuruKodu { get; set; }
        public string gideradi { get; set; }
        public ICollection<Giderler> Giderlers { get; set; }
    }
}
