using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class SinavController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            var degerler = c.sınavlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult SınavEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SınavEkle(EntityLayer.Tables.Sınavlar o)
        {
            c.sınavlars.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SınavGetir()
        {


            return View();
        }
        [HttpPost]
        public IActionResult SınavGetir(EntityLayer.Tables.Sınavlar o)
        {
            var degerler = c.sınavlars.Find(o.SınavKodu);

            return View("SınavGoster", degerler);

        }
    }
}
