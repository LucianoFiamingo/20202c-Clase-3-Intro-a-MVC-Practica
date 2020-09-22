using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class BienvenidoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string Saludo(string id)
        {
            return $"HOLA {id}!";
        }

        public string SaludoGrupal(string nombre1, string nombre2)
        {
            return $"HOLA {nombre1} y {nombre2}!";
        }

    }
}