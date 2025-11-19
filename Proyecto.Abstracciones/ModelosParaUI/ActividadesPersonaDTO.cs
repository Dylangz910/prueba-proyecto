using System;

namespace Proyecto.Abstracciones.ModelosParaUI
{
    public class ActividadesPersonaDTO
    {
        public int IdActividadPersona { get; set; }
        public int IdPersona { get; set; }
        public string NombreActividadFinanciera { get; set; }
        public int NivelDeRiesgo { get; set; }
        public DateTime FechaDeRegistro { get; set; }
    }
}
