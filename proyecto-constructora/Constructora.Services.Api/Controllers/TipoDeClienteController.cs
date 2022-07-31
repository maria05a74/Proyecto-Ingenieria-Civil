using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeClienteController : ControllerBase
    {
        // GET: api/<TipoDeClienteController>
        [HttpGet]
        public IEnumerable<TipoDeClienteDto> Get()
        {
            return new TipoDeClienteDto[]
           {
                new TipoDeClienteDto
                {

                },
                new TipoDeClienteDto
                {


                }
       };
        }

        // GET api/<TipoDeClienteController>/5
        [HttpGet("{id}")]
        public TipoDeClienteDto Get(int id)
        {
            return new TipoDeClienteDto();
        }

        // POST api/<TipoDeClienteController>
        [HttpPost]
        public void Post([FromBody] TipoDeClienteDto value)
        {
        }

        // PUT api/<TipoDeClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TipoDeClienteDto value)
        {
        }

        // DELETE api/<TipoDeClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
