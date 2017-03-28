using System.Web.Mvc;

namespace DemoDisableRequestValidation.Controllers
{
    public class HomeController : Controller
    {

        [ValidateInput(false)]
        public ActionResult Index(string comment)
        {
            ViewBag.Comment = comment;
            return View();
        }

    }
}
