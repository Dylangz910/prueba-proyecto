using System;

namespace Proyecto.AccesoADatos.Entidades
{
    public class ActividadPersona
    {
        public int IdActividadPersona { get; set; }
        public int IdPersona { get; set; }
        public int IdActividadFinanciera { get; set; }

        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeModificacion { get; set; }

        public bool Estado { get; set; }
    }
}
