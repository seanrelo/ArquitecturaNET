using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PruebaWerbService.Models;
using PruebaWerbService.Fachada;

namespace PruebaWerbService.Controllers
{

    public class PruebaController : ApiController
    {

        private readonly IFachada _fachada;

        public PruebaController(IFachada fachada) {
            this._fachada = fachada;
        }



        [Route("api/persona/all")]
        public List<Persona> GetAllPersonas() {
            return new List<Persona>();
        }

            
        [Route("api/persona/{id}")]
        public Persona GetPersona(int id) {
            return new Persona();
        }

        [Route("api/persona/crear")]
        public CrearPersonaResponse CrearPersona(Persona persona) {
            Console.WriteLine("Ingreso en el metodo");
            CrearPersonaResponse response = this._fachada.crearPersona(persona);
            return response;
        }

        [Route("api/persona/modificar")]
        public ModificarPersonaResponse PutPersona(Persona persona) {
            return new ModificarPersonaResponse();
        }
    }
}
