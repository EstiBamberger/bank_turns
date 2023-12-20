using Microsoft.AspNetCore.Mvc;
using Solid.Core.Enteties;
using Solid.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public Customers(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<Customers>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        // GET api/<Customers>/5
        [HttpGet("{tz}")]
        public ActionResult Get(string tz)
        {
            return Ok(_customerService.GetByTz(tz));
        }

        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _customerService.AddCustomer(value);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            _customerService.UpdateCustomer(id, value);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.DeleteCustomer(id);
        }
    }
}
