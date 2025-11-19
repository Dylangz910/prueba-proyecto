using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.UI.Controllers
{
    public class ActividadesFinancierasController : Controller
    {
        private readonly IObtenerListaDeActividadesFinancierasLN _obtenerLaListaDeActividadesFinancierasLN;
        public ActividadesFinancierasController()
        {
            _obtenerLaListaDeActividadesFinancierasLN = new ObtenerListaDeActividadesFinancierasLN();

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
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActividadesFinancieras/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ActividadesFinancieras/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActividadesFinancieras/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
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
