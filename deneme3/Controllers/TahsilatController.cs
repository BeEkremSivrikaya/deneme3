using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class TahsilatController : Controller
    {
        Context1 c = new Context1();

        /*
        public IActionResult Index()
        {


            var metin = c.borcs.ToList();
            return View(metin);

        }
        */

        public IActionResult OdemeDetay()
        {
            return View();
        }
    }
}