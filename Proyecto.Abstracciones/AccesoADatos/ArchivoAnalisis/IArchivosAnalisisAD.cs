using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.Abstracciones.Entidades.ArchivoAnalisis;
using System.Collections.Generic;

namespace Proyecto.Abstracciones.AccesoADatos.ArchivosAnalisis
{
    public interface IArchivosAnalisisAD
    {
        List<ArchivoAnalisisDTO> ListarPorPersona(int idPersona);
        ArchivoAnalisisDTO ObtenerPorId(int idArchivo);
        void Registrar(ArchivoAnalisis entidad);
        void Actualizar(ArchivoAnalisis entidad);
        void Eliminar(int idArchivo);
    }
}
