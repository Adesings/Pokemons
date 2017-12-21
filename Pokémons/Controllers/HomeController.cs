using Pokémons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokémons.Controllers
{
    public class HomeController : Controller
    {
        PokemonsEntities cnx;

        public HomeController()
        {
            cnx = new PokemonsEntities();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            List<Pokemon> nuevo = cnx.Pokemon.ToList();

            return View();
        }

        public ActionResult Guardar(string numero, string nombre, string tipo, string categoria, string descripcion, string altura, string peso, string sexo, string ataques, string habilidad, string debilidad, string evoluciones)
        {
            Pokemon nuevo = new Pokemon()
            {
                numero = numero,
                nombre = nombre,
                tipo = tipo,
                categoria = categoria,
                descripcion = descripcion,
                altura = altura,
                peso = peso,
                sexo = sexo,
                ataques = ataques,
                habilidad = habilidad,
                debilidad = debilidad,
                evoluciones = evoluciones
            };
            cnx.Pokemon.Add(nuevo);
            cnx.SaveChanges();

            return View("Listado", cnx.Pokemon.ToList());
        }

        public ActionResult Listado()
        {
            cnx.Database.Connection.Open();

            List<Pokemon> nuevo = cnx.Pokemon.ToList();
            cnx.Database.Connection.Close();

            return View();
        }

        public ActionResult Ficha(string numero)
        {
            
            return View(cnx.Pokemon.Where(x => x.numero.Equals(numero)).First());
        }
    }
}