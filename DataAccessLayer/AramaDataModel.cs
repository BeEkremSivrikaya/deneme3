using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml.Linq;

namespace EntitiyLayer.Tables
{
    public class AramaDataViewModel
    {
        public SelectListItem User { get; set; }

        [Display(Name = "Users")]
        public List<SelectListItem> Tabloisimleri { get; set; }
        public List<SelectListItem> Sutunisimleri { get; set; }
        public List<SelectListItem> KarsilastirmaOperatorleri { get; set; }
        public List<SelectListItem> BirlestirmeOperatorleri { get; set; }

    }
}
