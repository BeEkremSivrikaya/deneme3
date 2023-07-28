using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Tables;

namespace EntityLayer.Tables
{
    public class Banka
    {
        [Key]
        public int banka_Id { get; set; }
        public string Banka_Adi { get; set; }

        public ICollection<Odemeler> Odemelers{ get; set; }

    }
}
