using Microsoft.AspNetCore.Mvc;
using Solid.Core.Enteties;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunkTurns : ControllerBase
    {
        private readonly ITurnsServices _turnsServices;
        public BunkTurns(ITurnsServices turnsServices)
        {
            _turnsServices = turnsServices;
        }

        // GET: api/<BunkTurns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_turnsServices.GetTurns());
        }

        // GET api/<BunkTurns>/5
        [HttpGet("{start}")]
        public ActionResult Get(DateTime start)
        {
            return Ok(_turnsServices.GetByStart(start));
        }

        // POST api/<BunkTurns>
        [HttpPost]
        public void Post([FromBody] Turn value)
        {
            _turnsServices.AddTurn(value);
        }

        // PUT api/<BunkTurns>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn value)
        {
           _turnsServices.UpdateTurn(id, value);
        }

        // DELETE api/<BunkTurns>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _turnsServices.DeleteTurn(id);
        }
    }
}
