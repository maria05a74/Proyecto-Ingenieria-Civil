
using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        // GET: api/<CiudadController>
        [HttpGet]
        public IEnumerable<CiudadDto> Get()
        {
            return new CiudadDto[]
            {
                new CiudadDto
                {
                    
                },
                new CiudadDto
                {


                }
        };
        }



        // GET api/<CiudadController>/5
        [HttpGet("{id}")]
        public CiudadDto Get(int id)
        {
            return new CiudadDto();
        }

        // POST api/<CiudadController>
        [HttpPost]
        public void Post([FromBody] CiudadDto value)
        {
        }

        // PUT api/<CiudadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CiudadDto value)
        {
        }

        // DELETE api/<CiudadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
