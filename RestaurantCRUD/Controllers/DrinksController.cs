using Microsoft.AspNetCore.Mvc;
using RestaurantCRUD.Models;
using RestaurantCRUD.Services.Interfaces;
namespace RestaurantCRUD.Controllers
{
    public class DrinksController : Controller
    {
        public readonly IDrinksService _drinksService;
        public DrinksController(IDrinksService drinksService)
        {
            _drinksService = drinksService;
        }
        // GET: api/<DrinksController>
        [HttpGet]
        public async Task<ActionResult<List<Drink>>> GetAllDrinks()
        {
            var result = await _drinksService.GetAllDrinks();
            if (result == null) 
            {
                return NotFound("Data cannot be supplied");
            }
            return Ok(result);
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
