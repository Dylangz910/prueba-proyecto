using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Abstracciones.LogicaDeNegocio.ActividadesPersona
{
    public interface IRegistrarActividadPersonaLN
    {
        void Ejecutar(int idPersona, int idActividadFinanciera);
    }
}
