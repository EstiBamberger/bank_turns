using Microsoft.AspNetCore.Mvc;
using Solid.Core.Enteties;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Officials : ControllerBase
    {
        private readonly IOfficialsServices _officialsService;
        public Officials(IOfficialsServices officialsService)
        {
            _officialsService = officialsService;
        }
        // GET: api/<Officials>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_officialsService.GetOfficials());
        }

        // GET api/<Officials>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_officialsService.GetById(id));
        }

        // POST api/<Officials>
        [HttpPost]
        public void Post([FromBody] Official value)
        {
            _officialsService.AddOfficial(value);

        }

        // PUT api/<Officials>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Official value)
        {
            _officialsService.UpdateOfficial(id, value);
        }

        // DELETE api/<Officials>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _officialsService.DeleteOfficial(id);

        }
    }
}
