using Proyecto.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Abstracciones.AccesoADatos.ActividadesFinancieras.EditarActividadesFinancieras
{
    public interface IEditarActividadesFinancierasAD
    {
        int Editar(ActividadesFinancierasDTO lasActividadesFinancierasParaGuardar);
    }
}
