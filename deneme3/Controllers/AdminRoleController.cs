using deneme3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme3.Controllers
{
    public class AdminRoleController : Controller
    {
        public string[] GetRolesForUser(string username)
        {
            Context1 c = new Context1();
            var x = c.Admins.FirstOrDefault(y => y.Kullanici == username);
            return new string[] { x.Rol };

        }

    }
}
