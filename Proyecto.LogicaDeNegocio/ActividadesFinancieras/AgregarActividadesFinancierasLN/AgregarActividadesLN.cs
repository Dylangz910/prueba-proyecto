using Proyecto.Abstracciones.AccesoADatos.ActividadesFinancieras.AgregarActividadesFinancieras;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.AgregarActividadesFinancieras;
using Proyecto.Abstracciones.LogicaDeNegocio.General.GestionDeFechas;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.AccesoADatos.ActividadesFinancieras.AgregarActividadesFinancieras;
using Proyecto.LogicaDeNegocio.General.GestionDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LogicaDeNegocio.ActividadesFinancieras.AgregarActividadesFinancieras
{
    public class AgregarActividadesFinancierasLN : IAgregarActividadesFinancierasLN
    {
        private IAgregarActividadesFinancierasAD _agregarAgregarActividadesFinancierasAD;
        private IFecha _fecha;
        public AgregarActividadesFinancierasLN()
        {
            _agregarAgregarActividadesFinancierasAD = new AgregarActividadesFinancierasAD();
            _fecha = new Fecha();
        }

        public async Task<int> Agregar(ActividadesFinancierasDTO lasActividadesFinancierasParaGuardar)
        {
            lasActividadesFinancierasParaGuardar.FechaDeRegistro = _fecha.ObtenerFecha();
            lasActividadesFinancierasParaGuardar.FechaDeModificacion = null;
            int cantidadDeFilasAfectas = await _agregarAgregarActividadesFinancierasAD.Agregar(lasActividadesFinancierasParaGuardar);
            return cantidadDeFilasAfectas;
        }
    }
}

