using Proyecto.Abstracciones.ModelosParaUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras.ListaDeActividadesFinancieras
{
    public interface IObtenerListaDeActividadesFinancierasLN
    {
        List<ActividadesFinancierasDTO> Obtener();
    }
}
