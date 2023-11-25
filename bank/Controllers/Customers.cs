using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {
        private readonly DataContext _dataContext;
        public Customers(DataContext context)
        {
            _dataContext = context;
        }
        // GET: api/<Customers>
        [HttpGet]
        public List<Customer> Get()
        {
            return _dataContext.Customers;
        }

        // GET api/<Customers>/5
        [HttpGet("{tz}")]
        public Customer Get(string tz)
        {
            Customer c = _dataContext.Customers.Find(x => x.Tz == tz);
            return c;
        }

        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _dataContext.Customers.Add(value);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer value)
        {
            Customer c = _dataContext.Customers.Find(x => x.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            c.Tz = value.Tz;
            c.Name = value.Name;
            return Ok(c);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Customer c = _dataContext.Customers.Find(x => x.Id == id);
            if (c == null)
            {
                return NotFound(id);
            }
            _dataContext.Customers.Remove(c);
            return Ok(c);
        }
    }
}
