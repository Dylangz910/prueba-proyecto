using Proyecto.Abstracciones.AccesoADatos.ActividadesPersona;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesPersona;
using System;

namespace Proyecto.LogicaDeNegocio.ActividadesPersona
{
    public class RegistrarActividadPersona : IRegistrarActividadPersonaLN
    {
        private readonly IActividadesPersonaAD _ad;

        public RegistrarActividadPersona(IActividadesPersonaAD ad)
        {
            _ad = ad;
        }

        public void Ejecutar(int idPersona, int idActividadFinanciera)
        {
            if (idActividadFinanciera <= 0) return;

            var existente = _ad.ObtenerIdActividadPersona(idPersona, idActividadFinanciera);
            if (existente.HasValue)
            {
                _ad.Reactivar(existente.Value);
                return;
            }
            _ad.Registrar(idPersona, idActividadFinanciera);
        }
    }
}
