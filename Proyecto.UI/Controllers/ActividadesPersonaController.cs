using System;
using System.Web.Mvc;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesPersona;
using Proyecto.AccesoADatos.ActividadesPersona;
using Proyecto.LogicaDeNegocio.ActividadesPersona;

namespace Proyecto.UI.Controllers
{
    public class ActividadesPersonaController : Controller
    {
        private readonly IObtenerActividadesPersonaLN _obtenerLN;
        private readonly IRegistrarActividadPersonaLN _registrarLN;
        private readonly IEliminarActividadPersonaLN _eliminarLN;

        public ActividadesPersonaController()
        {
            var ad = new ActividadesPersonaAD();
            _obtenerLN = new ObtenerActividadesPersona(ad);
            _registrarLN = new RegistrarActividadPersona(ad);
            _eliminarLN = new EliminarActividadPersona(ad);
        }

        // GET: /ActividadesPersona/Ver/5
        public ActionResult Ver(int idPersona)
        {
            try
            {
                var vm = _obtenerLN.Ejecutar(idPersona);
                ViewBag.Persona = vm.Persona;
                ViewBag.ActividadesDisponibles = vm.Disponibles;
                return View(vm.Lista);
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("ListaDePersonas", "Personas");
            }
        }

        [HttpPost]
        public ActionResult Agregar(int idPersona, int idActividad)
        {
            _registrarLN.Ejecutar(idPersona, idActividad);
            return RedirectToAction("Ver", new { idPersona });
        }

        [HttpPost]
        public ActionResult Eliminar(int idActividadPersona, int idPersona)
        {
            _eliminarLN.Ejecutar(idActividadPersona);
            return RedirectToAction("Ver", new { idPersona });
        }
    }
}
