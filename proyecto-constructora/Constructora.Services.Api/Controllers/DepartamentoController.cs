using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        // GET: api/<DepartamentoController>
        [HttpGet]
        public IEnumerable<DepartamentoDto> Get()
        {
            return new DepartamentoDto[]
            {
                  new DepartamentoDto
                  {
                      DepartamentoId = 1,
                      Nombre = "Cauca"
                  },
                  new DepartamentoDto
                  {
                      DepartamentoId = 2,
                      Nombre = "Valle"
                  },
                  new DepartamentoDto
                  {
                      DepartamentoId = 3,
                      Nombre = "Cundinamarca"
                  }

            };
        }

        // GET api/<DepartamentoController>/5
        [HttpGet("{id}")]
        public DepartamentoDto Get(int id)
        {
            return new DepartamentoDto();
        }

        // POST api/<DepartamentoController>
        [HttpPost]
        public void Post([FromBody] DepartamentoDto value)
        {
        }

        // PUT api/<DepartamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DepartamentoDto value)
        {
        }

        // DELETE api/<DepartamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
