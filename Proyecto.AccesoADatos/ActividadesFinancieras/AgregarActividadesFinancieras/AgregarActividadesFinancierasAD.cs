using Proyecto.Abstracciones.AccesoADatos.ActividadesFinancieras.AgregarActividadesFinancieras;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.AccesoADatos.ActividadesFinancieras.AgregarActividadesFinancieras
{
    public class AgregarActividadesFinancierasAD : IAgregarActividadesFinancierasAD
    {
        private Contexto _elContexto;
        public AgregarActividadesFinancierasAD()
        {
            _elContexto = new Contexto();
        }
        public async Task<int> Agregar(ActividadesFinancierasDTO lasActividadesFinancierasParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            ActividadesFinancierasAD lasActividadesFinancierasEnEntidad = ConvierteObjetoAEntidad(lasActividadesFinancierasParaGuardar);
            _elContexto.ACTIVIDADES_FINANCIERAS.Add(lasActividadesFinancierasEnEntidad);
            cantidadDeFilasAfectadas = await _elContexto.SaveChangesAsync();
            return cantidadDeFilasAfectadas;
        }
        private ActividadesFinancierasAD ConvierteObjetoAEntidad(ActividadesFinancierasDTO lasActividadesFinancierasParaGuardar)
        {
            return new ActividadesFinancierasAD
            {
                NombreActividadFinanciera = lasActividadesFinancierasParaGuardar.NombreActividadFinanciera,
                DescripcionActividadFinanciera = lasActividadesFinancierasParaGuardar.DescripcionActividadFinanciera,
                NivelDeRiesgo = lasActividadesFinancierasParaGuardar.NivelDeRiesgo,
                FechaDeRegistro = lasActividadesFinancierasParaGuardar.FechaDeRegistro,
                FechaDeModificacion = lasActividadesFinancierasParaGuardar.FechaDeModificacion,
                Estado = lasActividadesFinancierasParaGuardar.Estado
                
            };
        }
    }
}
