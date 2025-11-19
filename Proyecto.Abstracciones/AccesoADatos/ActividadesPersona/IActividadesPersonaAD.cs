using System.Collections.Generic;
using Proyecto.Abstracciones.ModelosParaUI;

namespace Proyecto.Abstracciones.AccesoADatos.ActividadesPersona
{
    public interface IActividadesPersonaAD
    {
        List<ActividadesPersonaDTO> ListarActivasPorPersona(int idPersona);
        List<KeyValuePair<int, string>> ListarActividadesDisponibles(int idPersona);
        void Registrar(int idPersona, int idActividadFinanciera);
        void Eliminar(int idActividadPersona);
        int? ObtenerIdActividadPersona(int idPersona, int idActividadFinanciera); // para detectar duplicados / reactivación
        void Reactivar(int idActividadPersona);
    }
}
