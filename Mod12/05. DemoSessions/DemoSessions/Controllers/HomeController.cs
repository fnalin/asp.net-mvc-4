using DemoSessions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Providers.Entities;

namespace DemoSessions.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cliente cliente)
        {
            cliente.Id = Guid.NewGuid();
            
            if (Session["clientes"] == null)
            {
                Session["clientes"] = new List<Cliente>();
            }

            var clientes = (List<Cliente>)Session["clientes"];
            clientes.Add(cliente);
            Session["clientes"] = clientes;

            TempData["msg"] = string.Format("cliente {0} adicionado com sucesso!", cliente.Nome);
            return RedirectToAction("Index");
        }

    }
}