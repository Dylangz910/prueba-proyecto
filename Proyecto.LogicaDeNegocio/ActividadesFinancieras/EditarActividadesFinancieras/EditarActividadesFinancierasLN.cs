using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.EditarActividadesFinancieras;
using Proyecto.Abstracciones.LogicaDeNegocio.General.GestionDeFechas;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.AccesoADatos.ActividadesFinancieras.EditarActividadesFinancieras;
using Proyecto.LogicaDeNegocio.General.GestionDeFechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LogicaDeNegocio.ActividadesFinancieras.EditarActividadesFinancieras
{
    public class EditarActividadesFinancierasLN : IEditarActividadesFinancierasLN
    {
        private EditarActividadesFinancierasAD _editarActividadesFinancierasAD;
        private IFecha _fecha;
        public EditarActividadesFinancierasLN()
        {
            _editarActividadesFinancierasAD = new EditarActividadesFinancierasAD();
            _fecha = new Fecha();
        }
        public int Editar(ActividadesFinancierasDTO lasActividadesFinancierasParaEditar)
        {
            lasActividadesFinancierasParaEditar.FechaDeModificacion = _fecha.ObtenerFecha();
            int cantidadDeFilasAfectas = _editarActividadesFinancierasAD.Editar(lasActividadesFinancierasParaEditar);
            return cantidadDeFilasAfectas;
        }
    }
}
