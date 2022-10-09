using Microsoft.AspNetCore.Mvc;
using Simipja_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simipja_Api.Controllers
{
    [ApiController]
    [Route("Persona")]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        [Route ("Listar")]
        public dynamic ListarCliente()
        {
            List<Persona> clientes = new List<Persona>
           {
               new Persona
               {
                   ID="1",
                   Nombre="Daniel Galiux",
                   Edad="32",
                   Correo="Daniel.ASE@gmail.com",
               },
               new Persona
               {
                   ID="2",
                   Nombre="Julio Fernin",
                   Edad="32",
                   Correo="Juelio.EA@gmail.com",
               }
           };
            return clientes;
        }
        [HttpGet]
        [Route("ListarID")]

        public dynamic ListarClienteID(string _ID)
        {
            return new Persona
            {
                ID = "1",
                Correo = "mariaespo@gmail.com",
                Edad = "19",
                Nombre = "Maria Morales"
            };
        }
        [HttpPost]
        [Route("guardar")]

        public dynamic guardarCliente(Persona Persona)
        {
            Persona.ID = "2";
            return new
            {
                success = true,
                message = "cliente registrado",
                result = Persona,
            };
        }
        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Persona Persona)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            if (token != "marcos.")
            {
                return new
                {
                    success = false,
                    message = "Token Incorrecto",
                    result = Persona,
                };
            }
            return new
            {
                success = true,
                message = "Persona Eliminada",
                result = Persona,
            };
        }
    }
}



