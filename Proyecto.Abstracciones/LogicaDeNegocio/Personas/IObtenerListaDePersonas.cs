using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Abstracciones.Entidades;

namespace Proyecto.Abstracciones.LogicaDeNegocio.Personas
{
    public interface IObtenerListaDePersonas
    {
        List<Persona> Ejecutar();
    }
}