using Proyecto.Abstracciones.AccesoADatos.ActividadesFinancieras.ListaDeActividadesFinancieras;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.AccesoADatos.ActividadesFinancieras.ListaDeActividadesFinancieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras
{
    public class ObtenerListaDeActividadesFinancierasLN : IObtenerListaDeActividadesFinancierasLN
    {
        private readonly IObtenerListaDeActividadesFinancierasAD _obtenerListaDeActividadesFinancierasAD;

        public ObtenerListaDeActividadesFinancierasLN()
        {
            _obtenerListaDeActividadesFinancierasAD = new ObtenerListaDeActividadesFinancierasAD();
        }
        public List<ActividadesFinancierasDTO> Obtener()
        {
            List<ActividadesFinancierasDTO> laListaDeActividadesFinancieras = _obtenerListaDeActividadesFinancierasAD.Obtener();
            return laListaDeActividadesFinancieras;
        }

    }
}
