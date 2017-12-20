using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokémons.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            ViewBag.Message = "Ingreso de Pokémons.";

            return View();
        }

        public ActionResult Listado()
        {
            ViewBag.Message = "Listado de Pokémons";

            return View();
        }

        public ActionResult Ficha()
        {
            ViewBag.Message = "Ficha del Entrenador Pokémon.";

            return View();
        }
    }
}