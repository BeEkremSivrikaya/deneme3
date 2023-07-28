using Microsoft.AspNetCore.Mvc;

namespace deneme3.Controllers
{
    public class AccessController : Controller
    {
        [HttpGet]
        [Route("/Account/AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
