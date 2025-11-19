using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.AccesoADatos.Entidades
{
    [Table("ACTIVIDADES_PERSONA")]
    public class ActividadesPersonaAD
    {
        [Key]
        [Column("IDACTIVIDADPERSONA")]
        public int IdActividadPersona { get; set; }

        [Column("IDPERSONA")]
        public int IdPersona { get; set; }

        [Column("IDACTIVIDADFINANCIERA")]
        public int IdActividadFinanciera { get; set; }

        [Column("FECHADEREGISTRO")]
        public DateTime FechaDeRegistro { get; set; }

        [Column("FECHADEMODIFICACION")]
        public DateTime? FechaDeModificacion { get; set; }

        [Column("ESTADO")]
        public bool Estado { get; set; }
    }
}

