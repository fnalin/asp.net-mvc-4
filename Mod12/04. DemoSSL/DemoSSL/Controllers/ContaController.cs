using System.Web.Mvc;
using System.Web.Security;

namespace DemoSSL.Controllers
{
    [RequireHttps]
    public class ContaController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            if (user != pass)
            {
                FormsAuthentication.SetAuthCookie(user, false);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
