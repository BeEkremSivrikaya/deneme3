
using deneme3.Models;

using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;

namespace deneme3.Controllers
{
    public class AyarlarController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult YasGrubuEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YasGrubuEkle(YasGrubu o)
        {
            c.yasGrubus.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult SınavEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SınavEkle(SınavTurleri o)
        {
            c.sınavkodus.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GiderTuru()
        {

            return View();
        }
        [HttpPost]
        public IActionResult GiderTuru(GiderTurleri o)
        {
            c.giderturleris.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult OdemeTuru()
        {
            return View();

        }
        [HttpPost]
        public IActionResult OdemeTuru(OdemeTurleri o)
        {
            c.OdemeTurleris.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult SubeEkle()
        {
            return View();

        }
        [HttpPost]
        public IActionResult SubeEkle(Sube o)
        {
            c.subes.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
