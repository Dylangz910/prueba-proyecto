using Proyecto.Abstracciones.AccesoADatos.ActividadesFinancieras.ListaDeActividadesFinancieras;
using Proyecto.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.AccesoADatos.ActividadesFinancieras.ListaDeActividadesFinancieras
{
    public class ObtenerListaDeActividadesFinancierasAD : IObtenerListaDeActividadesFinancierasAD
    {
        private Contexto _elContexto;
        public ObtenerListaDeActividadesFinancierasAD()
        {
            _elContexto = new Contexto();
        }

        public List<ActividadesFinancierasDTO> Obtener()
        {
            List<ActividadesFinancierasDTO> laListaDeActividadesFinancieras = (from actividadesFinancieras in _elContexto.ACTIVIDADES_FINANCIERAS
                                                       select new ActividadesFinancierasDTO
                                                       {
                                                           IdActividadFinanciera = actividadesFinancieras.IdActividadFinanciera,
                                                           NombreActividadFinanciera = actividadesFinancieras.NombreActividadFinanciera,
                                                           DescripcionActividadFinanciera = actividadesFinancieras.DescripcionActividadFinanciera,
                                                           NivelDeRiesgo = actividadesFinancieras.NivelDeRiesgo,
                                                           FechaDeRegistro = actividadesFinancieras.FechaDeRegistro,
                                                           FechaDeModificacion = actividadesFinancieras.FechaDeModificacion,
                                                           Estado = actividadesFinancieras.Estado
                                                           
                                                       }).ToList();
            return laListaDeActividadesFinancieras;
        }
    }
}
