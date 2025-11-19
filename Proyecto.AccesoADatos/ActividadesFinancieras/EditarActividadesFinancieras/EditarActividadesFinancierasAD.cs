using Proyecto.Abstracciones.AccesoADatos.ActividadesFinancieras.EditarActividadesFinancieras;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.AccesoADatos.ActividadesFinancieras.EditarActividadesFinancieras
{
    public class EditarActividadesFinancierasAD : IEditarActividadesFinancierasAD
    {
        private Contexto _elContexto;
        public EditarActividadesFinancierasAD()
        {
            _elContexto = new Contexto();
        }
        public int Editar(ActividadesFinancierasDTO lasActividadesFinancierasParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            ActividadesFinancierasAD lasActividadesFinancierasEnBaseDeDatos = _elContexto.ACTIVIDADES_FINANCIERAS
                .Where(actividadesFinancierasABuscar =>
                actividadesFinancierasABuscar.IdActividadFinanciera == lasActividadesFinancierasParaGuardar.IdActividadFinanciera).FirstOrDefault();
            if (lasActividadesFinancierasEnBaseDeDatos != null)
            {
                lasActividadesFinancierasEnBaseDeDatos.NombreActividadFinanciera = lasActividadesFinancierasParaGuardar.NombreActividadFinanciera;
                lasActividadesFinancierasEnBaseDeDatos.DescripcionActividadFinanciera = lasActividadesFinancierasParaGuardar.DescripcionActividadFinanciera;
                lasActividadesFinancierasEnBaseDeDatos.Estado = lasActividadesFinancierasParaGuardar.Estado;
                lasActividadesFinancierasEnBaseDeDatos.FechaDeModificacion = lasActividadesFinancierasParaGuardar.FechaDeModificacion;
                cantidadDeFilasAfectadas = _elContexto.SaveChanges();
            }
            return cantidadDeFilasAfectadas;

        }
    }
}
