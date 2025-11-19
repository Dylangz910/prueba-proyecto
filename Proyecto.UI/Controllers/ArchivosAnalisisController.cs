using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ArchivosAnalisisController : Controller
{
    private readonly ArchivoAnalisisLN _logica;

    public ArchivosAnalisisController(ArchivoAnalisisLN logica)
    {
        _logica = logica;
    }

    public IActionResult Index()
    {
        List<ArchivoAnalisis> lista = _logica.Listar();
        return View(lista);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ArchivoAnalisis archivo)
    {
        if (ModelState.IsValid)
        {
            _logica.Crear(archivo);
            return RedirectToAction("Index");
        }

        return View(archivo);
    }

    public IActionResult Details(int id)
    {
        ArchivoAnalisis archivo = _logica.BuscarPorId(id);
        if (archivo == null)
        {
            return NotFound();
        }

        return View(archivo);
    }
}
