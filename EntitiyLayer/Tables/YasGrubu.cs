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
    public class YasGrubu
    {
        [Key]
        public int YasId { get; set; }
        public string YasGrupAdi { get; set; }
        public ICollection<Kur> Kurs { get; set; }


    }
}
