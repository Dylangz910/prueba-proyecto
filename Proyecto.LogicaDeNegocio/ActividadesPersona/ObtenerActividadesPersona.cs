using System;
using System.Collections.Generic;
using Proyecto.Abstracciones.AccesoADatos.ActividadesPersona;
using Proyecto.Abstracciones.LogicaDeNegocio.ActividadesPersona;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.Abstracciones.Entidades;
using Proyecto.AccesoADatos.Personas;

namespace Proyecto.LogicaDeNegocio.ActividadesPersona
{
    public class ObtenerActividadesPersona : IObtenerActividadesPersonaLN
    {
        private readonly IActividadesPersonaAD _ad;
        private readonly PersonaAD _personasAD;

        public ObtenerActividadesPersona(IActividadesPersonaAD ad)
        {
            _ad = ad;
            _personasAD = new PersonaAD(); // ya existe en tu solución
        }

        public (Persona Persona, List<ActividadesPersonaDTO> Lista, List<KeyValuePair<int, string>> Disponibles) Ejecutar(int idPersona)
        {
            var persona = _personasAD.ObtenerPorId(idPersona);
            if (persona == null) throw new ArgumentException("Persona no encontrada");

            var lista = _ad.ListarActivasPorPersona(idPersona);
            var disponibles = _ad.ListarActividadesDisponibles(idPersona);
            return (persona, lista, disponibles);
        }
    }
}
