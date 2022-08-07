using Constructora.Application.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Constructora.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeObraController : ControllerBase
    {
        // GET: api/<TipoDeObraController>
        [HttpGet]
        public IEnumerable<TipodeObraDto> Get()
        {
            return new TipodeObraDto[]

              {
                 new TipodeObraDto
                 {

                 },
                new TipodeObraDto
                {


                }
              };  
        }

        // GET api/<TipoDeObraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoDeObraController>
        [HttpPost]
        public void Post([FromBody] TipodeObraDto value)
        {
        }

        // PUT api/<TipoDeObraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoDeObraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
