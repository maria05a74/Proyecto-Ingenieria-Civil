using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<ClienteDto> Get()
        {
            return new ClienteDto[] 
            {
                new ClienteDto
                {
                    Nombres = "Alvaro",
                    Apellidos = "Alvarez",
                    Cedula_Nit = 123456789,
                    ClienteId = 1,
                    CorreoElectronico = "alvaro@alvarez.com",
                    MatriculaProfesional = "1234",
                    NumeroCelular = 1234,
                    Profesion = "Ingeniero de sistemas",
                    TipoCliente = new TipoDeClienteDto{ Nombre = "Persona Natural", TipoClienteId = 1},
                    TipoClienteId = 1
                },
                new ClienteDto
                {
                    Nombres = "Daniel",
                    Apellidos = "Yepes",
                    Cedula_Nit = 123456789,
                    ClienteId = 1,
                    CorreoElectronico = "alvaro@alvarez.com",
                    MatriculaProfesional = "1234",
                    NumeroCelular = 1234,
                    Profesion = "Ingeniero de sistemas",
                    TipoCliente = new TipoDeClienteDto{ Nombre = "Persona Natural", TipoClienteId = 1},
                    TipoClienteId = 1
                }
            };
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public ClienteDto Get(int id)
        {
            return new ClienteDto();
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] ClienteDto value)
        {
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClienteDto value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
