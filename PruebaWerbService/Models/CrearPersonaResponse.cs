using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaWerbService.Models
{
    public class CrearPersonaResponse
    {
        String status;
        String mensaje;

        public String Status{
            get{ return status;}
            set { status = value; }
        }

        public String Mensaje {
            get { return mensaje; }
            set { mensaje = value; }
        }
    }
}