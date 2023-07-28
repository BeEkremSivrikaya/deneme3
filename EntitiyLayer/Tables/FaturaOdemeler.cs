using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class FaturaOdemeler
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey(name: "Odemeler")]
        public int odeme_no { get; set; }
        public Odemeler Odemeler { get; set; }

        [ForeignKey(name: "Fatura")]
        public int fatura_no { get; set; }
        public Fatura Fatura { get; set; }

    }
}
