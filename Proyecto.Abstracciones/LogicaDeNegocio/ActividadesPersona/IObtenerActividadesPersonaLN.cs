using System.Collections.Generic;
using Proyecto.Abstracciones.ModelosParaUI;
using Proyecto.Abstracciones.Entidades;

namespace Proyecto.Abstracciones.LogicaDeNegocio.ActividadesPersona
{
    public interface IObtenerActividadesPersonaLN
    {
        (Persona Persona, List<ActividadesPersonaDTO> Lista, List<KeyValuePair<int, string>> Disponibles) Ejecutar(int idPersona);
    }
}
