using Proyecto.Abstracciones.AccesoADatos.ActividadesPersona;
using Proyecto.Abstracciones.Entidades;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.AccesoADatos.ActividadesPersona
{
    public class ActividadesPersonaAD : IActividadesPersonaAD
    {
        private readonly Contexto _ctx;

        public ActividadesPersonaAD()
        {
            _ctx = new Contexto();
        }

        public List<ActividadesPersonaDTO> ListarActivasPorPersona(int idPersona)
        {
            var query = from ap in _ctx.ACTIVIDADES_PERSONA
                        join af in _ctx.ACTIVIDADES_FINANCIERAS on ap.IdActividadFinanciera equals af.IdActividadFinanciera
                        where ap.IdPersona == idPersona && ap.Estado == true
                        orderby ap.FechaDeRegistro descending
                        select new ActividadesPersonaDTO
                        {
                            IdActividadPersona = ap.IdActividadPersona,
                            IdPersona = ap.IdPersona,
                            NombreActividadFinanciera = af.NombreActividadFinanciera,
                            NivelDeRiesgo = af.NivelDeRiesgo,
                            FechaDeRegistro = ap.FechaDeRegistro
                        };

            return query.ToList();
        }

        public List<KeyValuePair<int, string>> ListarActividadesDisponibles(int idPersona)
        {
            var asignadas = _ctx.ACTIVIDADES_PERSONA
                                .Where(x => x.IdPersona == idPersona && x.Estado)
                                .Select(x => x.IdActividadFinanciera)
                                .ToList();

            var disponibles = _ctx.ACTIVIDADES_FINANCIERAS
                                  .Where(a => a.Estado && !asignadas.Contains(a.IdActividadFinanciera))
                                  .OrderBy(a => a.NombreActividadFinanciera)
                                  .Select(a => new KeyValuePair<int, string>(a.IdActividadFinanciera, a.NombreActividadFinanciera))
                                  .ToList();

            return disponibles;
        }

        public void Registrar(int idPersona, int idActividadFinanciera)
        {
            var nuevo = new Proyecto.AccesoADatos.Entidades.ActividadesPersonaAD
            {
                IdPersona = idPersona,
                IdActividadFinanciera = idActividadFinanciera,
                FechaDeRegistro = DateTime.Now,
                Estado = true
            };
            _ctx.ACTIVIDADES_PERSONA.Add(nuevo);
            _ctx.SaveChanges();
        }

        public void Eliminar(int idActividadPersona)
        {
            var entidad = _ctx.ACTIVIDADES_PERSONA.Find(idActividadPersona);
            if (entidad == null) return;

            entidad.Estado = false;
            entidad.FechaDeModificacion = DateTime.Now;
            _ctx.SaveChanges();
        }

        public int? ObtenerIdActividadPersona(int idPersona, int idActividadFinanciera)
        {
            var existente = _ctx.ACTIVIDADES_PERSONA
                .FirstOrDefault(x => x.IdPersona == idPersona && x.IdActividadFinanciera == idActividadFinanciera);
            return existente?.IdActividadPersona;
        }

        public void Reactivar(int idActividadPersona)
        {
            var entidad = _ctx.ACTIVIDADES_PERSONA.Find(idActividadPersona);
            if (entidad == null) return;

            entidad.Estado = true;
            entidad.FechaDeModificacion = DateTime.Now;
            _ctx.SaveChanges();
        }
    }
}
