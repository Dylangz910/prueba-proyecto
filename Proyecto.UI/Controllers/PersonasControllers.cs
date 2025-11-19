using Proyecto.LogicaDeNegocio.Personas;
using Proyecto.AccesoADatos.Personas;
using Proyecto.Abstracciones.Entidades;
using System;
using System.Web.Mvc;

namespace Proyecto.UI.Controllers
{
    public class PersonasController : Controller
    {
        private readonly PersonaAD _personaAD = new PersonaAD();

        
        public ActionResult ListaDePersonas()
        {
            var obtenerPersonas = new ObtenerListaDePersonas(_personaAD);
            var lista = obtenerPersonas.Ejecutar();
            return View(lista);
        }

        public ActionResult Index()
        {
            return RedirectToAction("ListaDePersonas");
        }

        public ActionResult Details(int id)
        {
            var persona = _personaAD.ObtenerPorId(id);
            if (persona == null)
                return HttpNotFound();

            return View(persona);
        }

      
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                var existente = _personaAD.BuscarPorIdentificacion(persona.IdentificacionPersona);
                if (existente != null)
                {
                    ViewBag.Mensaje = "Ya existe una persona registrada con esta identificación.";
                    return View(persona);
                }

                persona.FechaDeRegistro = DateTime.Now;
                persona.FechaDeModificacion = DateTime.Now;
                persona.Estado = true;

                _personaAD.Agregar(persona);
                return RedirectToAction("ListaDePersonas");
            }
            return View(persona);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var persona = _personaAD.ObtenerPorId(id.Value);
            if (persona == null)
                return HttpNotFound();

            return View(persona);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var persona = _personaAD.ObtenerPorId(id);
            if (persona == null)
                return HttpNotFound();

            _personaAD.Eliminar(id);
            return RedirectToAction("ListaDePersonas");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var personaAD = new Proyecto.AccesoADatos.Personas.PersonaAD();
            var persona = personaAD.ObtenerPorId(id.Value);

            if (persona == null)
                return HttpNotFound();

            return View(persona);
        }


        public ActionResult VerActividades(int id)
        {
            
            return RedirectToAction("ListaDeActividadesPorPersona", "ActividadesPersona", new { personaId = id });
        }
    }
}

