﻿using Microsoft.AspNetCore.Mvc;

namespace RestaurantCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        // GET: api/<MealsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MealsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MealsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MealsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MealsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
