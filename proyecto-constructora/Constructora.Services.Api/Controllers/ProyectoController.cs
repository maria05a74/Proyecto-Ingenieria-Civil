using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        // GET: api/<ProyectoController>
        [HttpGet]
        public IEnumerable<ProyectoDto> Get()
         
        {
            return new ProyectoDto[]
            {
                new ProyectoDto
                {

                },
                new ProyectoDto
                {


                }
        };
        }
        // GET api/<ProyectoController>/5
        [HttpGet("{id}")]
        public ProyectoDto Get(int id)
        {
        return new ProyectoDto();
        }

        // POST api/<ProyectoController>
        [HttpPost]
        public void Post([FromBody] ProyectoDto value)
        {
        }

        // PUT api/<ProyectoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProyectoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
