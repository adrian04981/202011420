using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simipja_Api.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        [Route ("Listar")]
        public dynamic ListarCliente() 
    {
        return new { nombre = "Jesus", edad = "33" };
    }
        
//    [HttpPost]
//    [Route {"Guardar"}]
//        public dynamic listarGuardar()
//{
//}

    


    }
}
