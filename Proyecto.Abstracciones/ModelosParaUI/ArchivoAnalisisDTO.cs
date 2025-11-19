using System;

namespace Proyecto.Abstracciones.ModelosParaUI
{
    public class ArchivoAnalisisDTO
    {
        public int IdArchivoAnalisis { get; set; }
        public int IdPersona { get; set; }
        public string NombreArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public string Ruta { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime? FechaDeModificacion { get; set; }
    }
}
