using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.AccesoADatos.Entidades
{
    [Table("ACTIVIDADES_FINANCIERAS")]
    public class ActividadesFinancierasAD
    {
        [Key]
        [Column("IDACTIVIDADFINANCIERA")]
        public int IdActividadFinanciera { get; set; }
        [Column("NOMBREACTIVIDADFINANCIERA")]
        public string NombreActividadFinanciera { get; set; }
        [Column("DESCRIPCIONACTIVIDADFINANCIERA")]
        public string DescripcionActividadFinanciera { get; set; }
        [Column("NIVELDERIESGO")]
        public int NivelDeRiesgo { get; set; }
        [Column("FECHADEREGISTRO")]
        public DateTime FechaDeRegistro { get; set; }
        [Column("FECHADEMODIFICACION")]
        public DateTime? FechaDeModificacion { get; set; }
        [Column("ESTADO")]
        public bool Estado { get; set; }
    }
}
