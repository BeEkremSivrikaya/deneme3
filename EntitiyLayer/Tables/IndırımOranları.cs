using EntityLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class IndırımOranları
    {
        public int ID { get; set; }
        public string indirimismi { get; set; }
        public int indirimoranları { get; set; }
        public ICollection<OdemeTurleri> odemeTurleris { get; set; }

    }
}