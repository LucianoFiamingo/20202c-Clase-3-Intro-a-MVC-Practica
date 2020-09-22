using Entidades;
using Servicios;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AlimentoController : Controller
    {
        AlimentoServicio AlimentoServicio = new AlimentoServicio();

        // GET: Alimento
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        public ActionResult CrearConRequest()
        {
            Alimento alimento = new Alimento();
            alimento.Descripcion = Request["Descripcion"];

            AlimentoServicio.Crear(alimento);

            //return View("~/Views/Bienvenido/Index.cshtml");
            //return View("Crear");
            return RedirectToAction("Lista");
        }

        public ActionResult CrearConFormCollection(FormCollection form)
        {
            Alimento alimento = new Alimento();
            alimento.Descripcion = form["Descripcion"];

            AlimentoServicio.Crear(alimento);

            return RedirectToAction("Lista");
        }

        public ActionResult Crear(Alimento alimento)
        {
            AlimentoServicio.Crear(alimento);

            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            List<Alimento> todos = AlimentoServicio.ObtenerTodos();
            return View(todos);
        }

        public ActionResult Eliminar(int id)
        {
            AlimentoServicio.Eliminar(id);
            return RedirectToAction("Lista");
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Alimento alimentoActual = AlimentoServicio.ObtenerPorId(id);

            return View(alimentoActual);
        }

        [HttpPost]
        public ActionResult Modificar(Alimento alimento)
        {
            AlimentoServicio.Modificar(alimento);

            return RedirectToAction("Lista");
        }
    }
}
