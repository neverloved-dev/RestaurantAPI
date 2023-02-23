using Microsoft.AspNetCore.Mvc;

namespace RestaurantCRUD.Controllers
{
    public class DrinksController : Controller
    {
        // GET: api/<DrinksController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DrinksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DrinksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DrinksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DrinksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
