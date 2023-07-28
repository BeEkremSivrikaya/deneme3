using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace deneme3.Controllers
{
    public class FaturaController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            var degerler = c.fatura.ToList();
            return View(degerler);
        }
        

        [HttpGet]
        public IActionResult FaturaEkle()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult FaturaEkle(EntityLayer.Tables.Fatura o)
        {
            c.fatura.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult FaturaSorgu(string fatura_ad, string fatura_soyad)
        {
            var adin = fatura_ad;
            var soyadin = fatura_soyad;

            var query = c.fatura.Where(s => s.Birey_Adi == fatura_ad && s.Birey_Soyadi == fatura_soyad).ToList();

            return View(query);
        }

        public IActionResult FaturaDetay(int id)
        {
            var degerler = c.fatura.Find(id);

            return View(degerler);

        }
    }
}
