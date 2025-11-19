using System.Collections.Generic;
using System.Linq;
using Proyecto.Abstracciones.AccesoADatos.Personas;
using Proyecto.Abstracciones.Entidades;

namespace Proyecto.AccesoADatos.Personas
{
    public class PersonaAD : IPersonaAD
    {
        private readonly Contexto _contexto;

        public PersonaAD()
        {
            _contexto = new Contexto();
        }

        public List<Persona> ObtenerListaDePersonas()
        {
            return _contexto.Personas.ToList();
        }

        public Persona ObtenerPorId(int id)
        {
            return _contexto.Personas.FirstOrDefault(p => p.IdPersona == id);
        }

        public void Agregar(Persona persona)
        {
            _contexto.Personas.Add(persona);
            _contexto.SaveChanges();
        }
        public Persona BuscarPorIdentificacion(string identificacion)
        {
            return _contexto.Personas.FirstOrDefault(p => p.IdentificacionPersona == identificacion);
        }
        public void Eliminar(int id)
        {
            var persona = _contexto.Personas.Find(id);
            if (persona != null)
            {
                _contexto.Personas.Remove(persona);
                _contexto.SaveChanges();
            }
        }

        public void Actualizar(Persona persona)
        {
            _contexto.Entry(persona).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }
    }
}
