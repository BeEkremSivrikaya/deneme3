using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class VeliController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            var degerler = c.velis.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult VeliEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult VeliEkle(EntityLayer.Tables.Veli o)
        {
            c.velis.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult VeliGetir()
        {


            return View();
        }
        [HttpPost]
        public IActionResult VeliGetir(EntityLayer.Tables.Veli o)
        {
            var degerler = c.velis.Find(o.TckimlikNo);

            return View("VeliGoster", degerler);

        }
    }
}
