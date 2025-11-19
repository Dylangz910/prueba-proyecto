using Proyecto.Abstracciones.LogicaDeNegocio.General.GestionDeFechas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LogicaDeNegocio.General.GestionDeFechas
{
    public class Fecha : IFecha
    {
        public DateTime ObtenerFecha()
        {
            int zonaHoraria = int.Parse(ConfigurationManager.AppSettings["zonaHoraria"]);
            return DateTime.UtcNow.AddHours(zonaHoraria);
        }
    }
}
