using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Il
    {
        [Key]
        public int Id { get; set; }
        public string Ils { get; set; }
        public ICollection<Ilce> Ilces { get; set; }
        public ICollection<Sube> subes { get; set; }
    }
}
