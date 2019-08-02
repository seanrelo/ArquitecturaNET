using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PruebaWerbService.Models;

namespace PruebaWerbService.Fachada
{
    public class FachadaImpl : IFachada
    {
        public FachadaImpl() {

        }

        public CrearPersonaResponse crearPersona(Persona persona)
        {
            CrearPersonaResponse response = new CrearPersonaResponse();
            try {
                response.Status = "OK";
                response.Mensaje = "Se creo Satisfactoriamente";
            } catch (Exception e) {
                response.Status = "Error";
                response.Mensaje = e.Message;
            }
            return response;
        }
    }
}