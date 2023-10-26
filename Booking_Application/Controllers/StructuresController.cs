using Booking_Business.Business.StructuresBusiness;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StructuresController : ControllerBase
    {
        IStructuresBusiness _structuresBusiness;

        public StructuresController(IStructuresBusiness structuresBusiness)
        {
            _structuresBusiness = structuresBusiness ?? throw new ArgumentNullException(nameof(structuresBusiness));
        }

        // GET: api/<StructuresController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var item = await _structuresBusiness.ListerAsync();

            return Ok(item);
        }

        //// GET api/<StructuresController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<StructuresController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<StructuresController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StructuresController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
