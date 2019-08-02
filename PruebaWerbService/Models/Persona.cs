using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaWerbService.Models
{
    public class Persona
    {
        String primerNombre;
        String segundoNombre;
        String primerApellido;
        String segundoApellido;
        int numeroIdentificacion;

        public String PrimerNombre {
            get { return primerNombre; }
            set { primerNombre = value; }
        }

        public String SegundoNombre {
            get { return segundoNombre; }
            set { segundoNombre = value; }
        }

        public String PrimerApellido {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public String SegundoApellido {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public int NumeroIdentificacion {
            get { return numeroIdentificacion; }
            set { numeroIdentificacion = value; }
        }
        
    }
}