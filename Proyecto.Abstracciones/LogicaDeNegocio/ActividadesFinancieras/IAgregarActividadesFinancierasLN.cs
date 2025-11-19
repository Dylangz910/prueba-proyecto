using Proyecto.Abstracciones.ModelosParaUI;
using System.Threading.Tasks;

namespace Proyecto.Abstracciones.LogicaDeNegocio.ActividadesFinancieras
{
    public interface IAgregarActividadesFinancierasLN
    {
        Task<int> Agregar(ActividadesFinancierasDTO actividades);
    }
}
