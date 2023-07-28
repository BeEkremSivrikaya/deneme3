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
    public class Ilce
    {
        [Key]
        public int Id { get; set; }
        public string Ilces { get; set; }
        [ForeignKey(name: "Il")]
        public int Il_Id { get; set; }
        public Il Ils { get; set; }

    }
}
