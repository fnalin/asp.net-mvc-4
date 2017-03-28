using System.Web.Mvc;
using Microsoft.Security.Application;


namespace DemoXSS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string msg)
        {
            ViewBag.Msg = msg;
            return View();
        }

    }
}
