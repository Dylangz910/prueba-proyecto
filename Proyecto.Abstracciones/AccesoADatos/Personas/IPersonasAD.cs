using System.Collections.Generic;
using Proyecto.Abstracciones.Entidades;


namespace Proyecto.Abstracciones.AccesoADatos.Personas
{
    public interface IPersonaAD
    {
        List<Persona> ObtenerListaDePersonas();
        Persona ObtenerPorId(int id);
        void Agregar(Persona persona);
        void Actualizar(Persona persona);
    }
}