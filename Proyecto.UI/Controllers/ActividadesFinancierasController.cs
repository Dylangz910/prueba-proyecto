using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.AgregarActividadesFinancieras;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.LogicaDeNegocio.ActividadesFinancieras.AgregarActividadesFinancieras;
using Proyecto.LogicaDeNegocio.ActividadesFinancieras.EditarActividadesFinancieras;
using Proyecto.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.UI.Controllers
{
    public class ActividadesFinancierasController : Controller
    {
        private readonly IObtenerListaDeActividadesFinancierasLN _obtenerLaListaDeActividadesFinancierasLN;
        private readonly EditarActividadesFinancierasLN _editarActividadesFinancierasLN;
        private readonly AgregarActividadesFinancierasLN _agregarActividadesFinancierasLN;
        public ActividadesFinancierasController()
        {
            _obtenerLaListaDeActividadesFinancierasLN = new ObtenerListaDeActividadesFinancierasLN();
            _editarActividadesFinancierasLN = new EditarActividadesFinancierasLN();
            _agregarActividadesFinancierasLN = new AgregarActividadesFinancierasLN();
        }



        // GET: ActividadesFinancieras
        public ActionResult ListaDeActividadesFinancieras()
        {
            List<ActividadesFinancierasDTO> laListaDeActividadesFinancieras = _obtenerLaListaDeActividadesFinancierasLN.Obtener();
            return View(laListaDeActividadesFinancieras);
        }

        public List<ActividadesFinancierasDTO> ListaDeActividadesFinancierasAPI()
        {
            List<ActividadesFinancierasDTO> laListaDeActividadesFinancieras = _obtenerLaListaDeActividadesFinancierasLN.Obtener();
            return laListaDeActividadesFinancieras;
        }

        // GET: ActividadesFinancieras/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActividadesFinancieras/Create
        public ActionResult AgregarActividadesFinancieras()
        {
            return View();
        }

        // POST: ActividadesFinancieras/Create
        [HttpPost]
        public async Task<ActionResult> AgregarActividadesFinancieras(ActividadesFinancierasDTO lasActividadesFinancierasParaGuardar)
        {
            try
            {
                // TODO: Add insert logic here
                int cantidadDeFilasAfectadas = await _agregarActividadesFinancierasLN.Agregar(lasActividadesFinancierasParaGuardar);

                return RedirectToAction("ListaDeActividadesFinancieras");
            }
            catch
            {
                return View();
            }
        }

        // GET: ActividadesFinancieras/Edit/5
        public ActionResult Editar(int id)
        {
            ActividadesFinancierasDTO modelo = _obtenerLaListaDeActividadesFinancierasLN
                                        .Obtener()
                                        .FirstOrDefault(x => x.IdActividadFinanciera == id);
            return View(modelo);
        }

        // POST: ActividadesFinancieras/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, ActividadesFinancierasDTO modelo)
        {
            try
            {
                // TODO: Add update logic here
                int cantidadDeFilasAfectadas = _editarActividadesFinancierasLN.Editar(modelo);
                return RedirectToAction("ListaDeActividadesFinancieras");
            }
            catch
            {
                return View();
            }
        }

        // GET: ActividadesFinancieras/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActividadesFinancieras/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
