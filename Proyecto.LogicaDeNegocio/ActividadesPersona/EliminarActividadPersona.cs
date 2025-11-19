using Proyecto.Abstracciones.AccesoADatos.ActividadesPersona;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesPersona;

namespace Proyecto.LogicaDeNegocio.ActividadesPersona
{
    public class EliminarActividadPersona : IEliminarActividadPersonaLN
    {
        private readonly IActividadesPersonaAD _ad;

        public EliminarActividadPersona(IActividadesPersonaAD ad)
        {
            _ad = ad;
        }

        public void Ejecutar(int idActividadPersona)
        {
            _ad.Eliminar(idActividadPersona);
        }
    }
}
