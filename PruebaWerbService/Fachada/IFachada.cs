using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PruebaWerbService.Models;

namespace PruebaWerbService.Fachada
{
    public interface IFachada
    {
        CrearPersonaResponse crearPersona(Persona persona);
    }
}
