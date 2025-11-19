using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Abstracciones.ModelosParaUI
{
    public class ActividadesFinancierasDTO
    {
        public int IdActividadFinanciera { get; set; }
        public string NombreActividadFinanciera { get; set; }
        public string DescripcionActividadFinanciera { get; set; }
        public int NivelDeRiesgo { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeModificacion { get; set; }
        public bool Estado { get; set; }
    }
}
