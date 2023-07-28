using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class SubeController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            var degerler = c.subes.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult SubeEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SubeEkle(EntityLayer.Tables.Sube o)
        {
            o.Il = c.Ils.Find(o.Il_Id);
            c.subes.Add(o);
           
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SubeGetir()
        {


            return View();
        }
        [HttpPost]
        public IActionResult SubeGetir(EntityLayer.Tables.Sube o)
        {
            var degerler = c.subes.Find(o.Sube_Id);

            return View("SubeGoster", degerler);

        }
    }
}
