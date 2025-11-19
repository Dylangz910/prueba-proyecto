using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Abstracciones.Entidades;
using Proyecto.Abstracciones.Entidades.ArchivoAnalisis;
using Proyecto.AccesoADatos.Entidades;

namespace Proyecto.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }
        public DbSet<ActividadesFinancierasAD> ACTIVIDADES_FINANCIERAS { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<ActividadesPersonaAD> ACTIVIDADES_PERSONA { get; set; }
        public DbSet<ArchivoAnalisis> ARCHIVOS_ANALISIS { get; set; }


    }
}
