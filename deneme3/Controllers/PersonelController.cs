using deneme3.Models;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace deneme3.Controllers
{
    public class PersonelController : Controller
    {
        Context1 c = new Context1();
        public IActionResult Index()
        {
            var degerler = c.personels.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult PersonelEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult PersonelEkle(Personel o)
        {
            
            var per = c.subes.Where(x => x.Sube_Id == o.Sube_Id).FirstOrDefault();
            o.Sube = per;
            c.personels.Add(o);
            c.SaveChanges();

            
        
            
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult PersonelGetir()
        {


            return View();
        }
        [HttpPost]
        public IActionResult PersonelGetir(EntityLayer.Tables.Personel o)
        {
            var degerler = c.personels.Find(o.PersonelId);

            return View("PersonelGoster", degerler);

        }
    }
}
