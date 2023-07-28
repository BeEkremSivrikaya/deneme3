using deneme3.Models;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class YetkiController : Controller
    {
        Context1 c = new Context1();

        public IActionResult Index()
        {
            var degerler = c.Admins.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult Yetkilendir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yetkilendir(Admin o)
        {
            c.Admins.Add(o);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
