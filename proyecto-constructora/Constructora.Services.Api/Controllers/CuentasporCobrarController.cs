using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasporCobrarController : ControllerBase
    {
        // GET: api/<CuentasporCobrarController>
        [HttpGet]
        public IEnumerable<Application.Dto.CuentasporCobrarDto> Get()
        {
            return new CuentasporCobrarDto[]
                {
                  new  CuentasporCobrarDto

                     {

                     },
                    new CuentasporCobrarDto
                    {


                    }
            };
        }
        // GET api/<CuentasporCobrarController>/5
        [HttpGet("{id}")]
        public CuentasporCobrarDto Get(int id)
        {
            return new CuentasporCobrarDto();
                
        }

        // POST api/<CuentasporCobrarController>
        [HttpPost]
        public void Post([FromBody] CuentasporCobrarDto value)
        {
        }

        // PUT api/<CuentasporCobrarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CuentasporCobrarDto value)
        {
        }

        // DELETE api/<CuentasporCobrarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
