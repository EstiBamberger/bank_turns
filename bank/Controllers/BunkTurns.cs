using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunkTurns : ControllerBase
    {
        private readonly DataContext _dataContext;
        public BunkTurns(DataContext context)
        {
            _dataContext = context;
        }

        // GET: api/<BunkTurns>
        [HttpGet]
        public List<Turn> Get()
        {
            return _dataContext.Turns;
        }

        // GET api/<BunkTurns>/5
        [HttpGet("{start}")]
        public List<Turn> Get(DateTime start)
        {
            List<Turn> t= _dataContext.Turns.FindAll((e)=>e.Start.Month == start.Month);
            return t;
        }

        // POST api/<BunkTurns>
        [HttpPost]
        public void Post([FromBody] Turn value)
        {
            _dataContext.Turns.Add(value);
        }

        // PUT api/<BunkTurns>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Turn value)
        {
           Turn t= _dataContext.Turns.Find((e)=>e.Id == id);
            if (t == null)
            {
                return NotFound();
            }
            t.Start = value.Start;
            t.Cust = value.Cust;
            t.Official = value.Official;
            return Ok(t);
        }

        // DELETE api/<BunkTurns>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Turn t = _dataContext.Turns.Find((e) => e.Id == id);
            if (t == null)
            {
                return NotFound(t);
            }
            _dataContext.Turns.Remove(t);
            return Ok(t);
        }
    }
}
