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
        PokemonsEntities2 cnx;

        public HomeController()
        {
            cnx = new PokemonsEntities2();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {

            return View();
        }

        public ActionResult Guardar( int id_pokemon, string nombre, string tipo, string categoria, string descripcion, string altura, string peso, string sexo, string ataques, string habilidad, string debilidad, string evoluciones) 
        {
            Pokemon nuevo = new Pokemon()
            {
                Id_Pokemon = id_pokemon,
                Nombre = nombre,
                Tipo = tipo,
                Categoria = categoria,
                Descripcion = descripcion,
                Altura = altura,
                Peso = peso,
                Sexo = sexo,
                Ataques = ataques,
                Habilidad = habilidad,
                Debilidad = debilidad,
                Evoluciones = evoluciones
            };
            cnx.Pokemon.Add(nuevo);
            cnx.SaveChanges();

            return View("Listado", cnx.Pokemon.ToList());
        }

        public ActionResult Listado()
        { 
            return View(cnx.Pokemon.ToList());
        }

        public ActionResult Ficha(int id_pokemon)
        {
            
            return View(cnx.Pokemon.Where(x => x.Id_Pokemon == id_pokemon).First());
        }
    }
}