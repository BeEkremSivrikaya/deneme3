using deneme3.Models;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace deneme3.Controllers
{
    public class LoginController : Controller
    {
        Context1 c = new Context1();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);

            if (bilgiler != null) 
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.Kullanici),
                    new Claim(ClaimTypes.Role, bilgiler.Rol),
                    new Claim(ClaimTypes.UserData, bilgiler.Personel_Sube_Adı)
                };

                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("YeniDepartman", "Ogrenci");

            }

            //Kullanıcı Bulunamadıysa:
            ViewData["LoginFlag"] = "Hatalı Kullanıcı Adı Veya Şifre!";

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }
    }
}
