using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class ArchivoAnalisisAD
{
    private readonly ApplicationDbContext _contexto;

    public ArchivoAnalisisAD(ApplicationDbContext contexto)
    {
        _contexto = contexto;
    }

    public List<ArchivoAnalisis> Details()
    {
        List<ArchivoAnalisis> lista = _contexto.ArchivosAnalisis.ToList();
        return lista;
    }

    public ArchivoAnalisis BuscarPorId(int id)
    {
        ArchivoAnalisis archivo = _contexto.ArchivosAnalisis.FirstOrDefault(a => a.IdArchivo == id);
        return archivo;
    }

    public void Create(ArchivoAnalisis archivo)
    {
        archivo.FechaDeRegistro = DateTime.Now;
        _contexto.ArchivosAnalisis.Add(archivo);
        _contexto.SaveChanges();
    }
}
