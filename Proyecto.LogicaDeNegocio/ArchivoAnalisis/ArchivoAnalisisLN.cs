using System.Collections.Generic;
using Proyecto.Abstracciones.AccesoADatos.ArchivosAnalisis;
using Proyecto.Abstracciones.Entidades.ArchivoAnalisis;
using Proyecto.Abstracciones.ModelosParaUI;

namespace Proyecto.LogicaDeNegocio
{
    public class ArchivosAnalisisLN
    {
        private readonly IArchivosAnalisisAD _ad;

        public ArchivosAnalisisLN(IArchivosAnalisisAD ad)
        {
            _ad = ad;
        }

        public List<ArchivoAnalisisDTO> ListarPorPersona(int idPersona)
        {
            List<ArchivoAnalisisDTO> lista = _ad.ListarPorPersona(idPersona);
            return lista;
        }

        public ArchivoAnalisisDTO Obtener(int idArchivo)
        {
            ArchivoAnalisisDTO dto = _ad.ObtenerPorId(idArchivo);
            return dto;
        }

        public void Registrar(int idPersona, string nombre, string tipo, string ruta)
        {
            ArchivoAnalisis entidad = new ArchivoAnalisis();
            entidad.IdPersona = idPersona;
            entidad.NombreArchivo = nombre;
            entidad.TipoArchivo = tipo;
            entidad.Ruta = ruta;

            _ad.Registrar(entidad);
        }

        public void Actualizar(int id, string nombre, string tipo, string ruta)
        {
            ArchivoAnalisis entidad = new ArchivoAnalisis();
            entidad.IdArchivoAnalisis = id;
            entidad.NombreArchivo = nombre;
            entidad.TipoArchivo = tipo;
            entidad.Ruta = ruta;

            _ad.Actualizar(entidad);
        }

        public void Eliminar(int idArchivo)
        {
            _ad.Eliminar(idArchivo);
        }
    }
}
