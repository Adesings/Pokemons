using Pokémons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokémons.Controllers
{
    public class EntrenadorController : Controller
    {
        PokemonsEntities2 cnx;

        public EntrenadorController()
        {
            cnx = new PokemonsEntities2();
        }
        // GET: Entrenador
        public ActionResult Index()
        {
            return View();
        }

        // GET: Entrenador/Details/5
        public ActionResult Formulario_Entrenador()
        {

            return View();
        }

        // GET: Entrenador/Create
        public ActionResult Guardar(string id_entrenador, string nombre, int edad, string pueblo, int num_medallas, string nom_medallas)
        {
            Entrenadores entrenador = new Entrenadores()
            {
                Id_Entrenador = id_entrenador,
                Nombre = nombre,
                Edad = edad,
                Pueblo = pueblo,
                Num_Medallas = num_medallas,
                Nom_Medallas = nom_medallas,
            };
            cnx.Entrenadores.Add(entrenador);
            cnx.SaveChanges();

            return View("Detalle_Entrenador", cnx.Entrenadores.ToList());
        }

        //Listado
        public ActionResult Detalle_Entrenador()
        {
            
            return View(cnx.Entrenadores.ToList());
        }

        //Ficha
        public ActionResult Ficha_Entrenador(string id_entrenador)
        {

            return View(cnx.Entrenadores.Where(x => x.Id_Entrenador.Equals("id_entrenador")).First());
        }

        // GET: Entrenador/Edit/5
        public ActionResult Edit(string id_entrenador)
        {
            return View();
        }

        // POST: Entrenador/Edit/5
        [HttpPost]
        public ActionResult Edit(string id_entrenador, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Formulario_Entrenador");
            }
            catch
            {
                return View();
            }
        }

        // GET: Entrenador/Delete/5
        public ActionResult Delete(string id_entrenador)
        {
            return View();
        }

        // POST: Entrenador/Delete/5
        [HttpPost]
        public ActionResult Delete(string id_entrenador, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Formulario_Entrenador");
            }
            catch
            {
                return View();
            }
        }
    }
}
