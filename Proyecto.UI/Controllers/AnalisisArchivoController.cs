using Proyecto.AccesoADatos.ArchivosAnalisis;
using Proyecto.LogicaDeNegocio;
using System.Web.Mvc;

namespace Proyecto.UI.Controllers
{
    public class AnalisisArchivoController : Controller
    {
        private readonly ArchivosAnalisisLN _ln;

        public AnalisisArchivoController()
        {
            _ln = new ArchivosAnalisisLN(new ArchivosAnalisisAD());
        }

        public ActionResult Index(int idPersona)
        {
            var lista = _ln.ListarPorPersona(idPersona);
            return View(lista);
        }

        public ActionResult Crear(int idPersona)
        {
            ViewBag.IdPersona = idPersona;
            return View();
        }

        [HttpPost]
        public ActionResult Crear(int idPersona, string nombre, string tipo, string ruta)
        {
            _ln.Registrar(idPersona, nombre, tipo, ruta);
            return RedirectToAction("Index", new { idPersona = idPersona });
        }

        public ActionResult Editar(int idArchivo)
        {
            var modelo = _ln.Obtener(idArchivo);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Editar(int idArchivo, string nombre, string tipo, string ruta)
        {
            _ln.Actualizar(idArchivo, nombre, tipo, ruta);
            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int idArchivo, int idPersona)
        {
            _ln.Eliminar(idArchivo);
            return RedirectToAction("Index", new { idPersona = idPersona });
        }
    }
}
