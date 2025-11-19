using Proyecto.Abstracciones.AccesoADatos.Personas;
using Proyecto.Abstracciones.Entidades;
using Proyecto.Abstracciones.LogicaDeNegocio.Personas;
using Proyecto.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto.LogicaDeNegocio.Personas
{
    public class ObtenerListaDePersonas : IObtenerListaDePersonas
    {
        private readonly IPersonaAD _personaAD;

        public ObtenerListaDePersonas(IPersonaAD personaAD)
        {
            _personaAD = personaAD;
        }

        public List<Persona> Ejecutar()
        {
            
            return _personaAD.ObtenerListaDePersonas();
        }
    }
}