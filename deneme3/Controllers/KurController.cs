using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class KurController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            var degerler = c.kurs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult KurEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult KurEkle(EntityLayer.Tables.Kur o)
        {
            c.kurs.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult KurGetir()
        {


            return View();
        }
        [HttpPost]
        public IActionResult KurGetir(EntityLayer.Tables.Kur o)
        {
            var degerler = c.kurs.Find(o.KurId);

            return View("KurGoster", degerler);

        }
    }
}
