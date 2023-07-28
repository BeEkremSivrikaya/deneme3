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
    public class OdemeTurleri//odemeturleriden belirtilmemiş şeçeği olmalı 
    {
        [Key]
        public int odemeTur_Id { get; set; }
        public string OdemeTurAdi { get; set; }

        public ICollection<Odemeler> Odemelers { get; set; }

        [ForeignKey(name: "IndırımOrnaları")]
        public int ID { get; set; }

        public IndırımOranları IndırımOranları { get; set; }
    }
}