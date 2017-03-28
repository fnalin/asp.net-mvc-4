using System.Web.Mvc;

namespace DEMOCSRF.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string msg)
        {
            ViewBag.Msg = msg;
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro(string usuario, string senha)
        {
            var mensagem = 
                string.Format("Usuário {0} verificado c/ sucesso", 
                usuario); 
            return RedirectToAction("Index", new { msg = mensagem});
        }

    }
}
