using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto.Abstracciones.AccesoADatos.ArchivosAnalisis;
using Proyecto.Abstracciones.Entidades;
using Proyecto.Abstracciones.Entidades.ArchivoAnalisis;
using Proyecto.Abstracciones.ModelosParaUI;

namespace Proyecto.AccesoADatos.ArchivosAnalisis
{
    public class ArchivosAnalisisAD : IArchivosAnalisisAD
    {
        private readonly Contexto _ctx;

        public ArchivosAnalisisAD()
        {
            _ctx = new Contexto();
        }

        public List<ArchivoAnalisisDTO> ListarPorPersona(int idPersona)
        {
            IQueryable<ArchivoAnalisis> tablaArchivos = _ctx.ARCHIVOS_ANALISIS;

            IQueryable<ArchivoAnalisisDTO> query =
                from a in tablaArchivos
                where a.IdPersona == idPersona && a.Estado == true
                orderby a.FechaDeRegistro descending
                select new ArchivoAnalisisDTO
                {
                    IdArchivoAnalisis = a.IdArchivoAnalisis,
                    NombreArchivo = a.NombreArchivo,
                    TipoArchivo = a.TipoArchivo,
                    Ruta = a.Ruta,
                    Estado = a.Estado,
                    FechaDeRegistro = a.FechaDeRegistro
                };

            List<ArchivoAnalisisDTO> resultado = query.ToList();
            return resultado;
        }

        public ArchivoAnalisisDTO ObtenerPorId(int idArchivo)
        {
            ArchivoAnalisis entidad = _ctx.ARCHIVOS_ANALISIS.Find(idArchivo);
            if (entidad == null)
            {
                return null;
            }

            ArchivoAnalisisDTO dto = new ArchivoAnalisisDTO();
            dto.IdArchivoAnalisis = entidad.IdArchivoAnalisis;
            dto.NombreArchivo = entidad.NombreArchivo;
            dto.TipoArchivo = entidad.TipoArchivo;
            dto.Ruta = entidad.Ruta;
            dto.Estado = entidad.Estado;
            dto.FechaDeRegistro = entidad.FechaDeRegistro;

            return dto;
        }

        public void Registrar(ArchivoAnalisis entidad)
        {
            entidad.Estado = true;
            entidad.FechaDeRegistro = DateTime.Now;

            _ctx.ARCHIVOS_ANALISIS.Add(entidad);
            _ctx.SaveChanges();
        }

        public void Actualizar(ArchivoAnalisis entidad)
        {
            ArchivoAnalisis db = _ctx.ARCHIVOS_ANALISIS.Find(entidad.IdArchivoAnalisis);
            if (db == null)
            {
                return;
            }

            db.NombreArchivo = entidad.NombreArchivo;
            db.TipoArchivo = entidad.TipoArchivo;
            db.Ruta = entidad.Ruta;
            db.FechaDeModificacion = DateTime.Now;

            _ctx.SaveChanges();
        }

        public void Eliminar(int idArchivo)
        {
            ArchivoAnalisis db = _ctx.ARCHIVOS_ANALISIS.Find(idArchivo);
            if (db == null)
            {
                return;
            }

            db.Estado = false;
            db.FechaDeModificacion = DateTime.Now;

            _ctx.SaveChanges();
        }
    }
}
