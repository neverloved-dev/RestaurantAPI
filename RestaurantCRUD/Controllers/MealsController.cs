using Microsoft.AspNetCore.Mvc;
using RestaurantCRUD.Models;
using RestaurantCRUD.Services.Interfaces;
namespace RestaurantCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        public readonly IMealsService _mealsService;
        public MealsController(IMealsService mealsService)
        {
            _mealsService = mealsService;
        }

        // GET: api/<MealsController>
        [HttpGet]
        public async Task<ActionResult<List<Meal>>> GetAll()
        {
            var result = await _mealsService.GetAll();
            if(result == null)
            {
                return NotFound("Data cannot be supplied");
            }
            return Ok(result);
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
