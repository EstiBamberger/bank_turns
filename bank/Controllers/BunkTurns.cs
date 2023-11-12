﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunkTurns : ControllerBase
    {
        public static List<Turn> turns = new List<Turn>();

        // GET: api/<BunkTurns>
        [HttpGet]
        public List<Turn> Get()
        {
            return turns;
        }

        // GET api/<BunkTurns>/5
        [HttpGet("{start}")]
        public List<Turn> Get(DateTime start)
        {
            List<Turn> t=turns.FindAll((e)=>e.Start.Month == start.Month);
            return t;
        }

        // POST api/<BunkTurns>
        [HttpPost]
        public void Post([FromBody] Turn value)
        {
              turns.Add(value);
        }

        // PUT api/<BunkTurns>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Turn value)
        {
           Turn t=turns.Find((e)=>e.Id == id);
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
            Turn t = turns.Find((e) => e.Id == id);
            if (t == null)
            {
                return NotFound(t);
            }
            turns.Remove(t);
            return Ok(t);
        }
    }
}