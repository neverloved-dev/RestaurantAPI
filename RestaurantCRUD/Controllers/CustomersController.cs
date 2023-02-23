using RestaurantCRUD.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RestaurantCRUD.Models;

namespace RestaurantCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public readonly ICustomerService _customersService;
        public CustomersController(ICustomerService customersService)
        {
            _customersService = customersService;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<ActionResult<List<Customer>>>GetAll()
        {
            var result = await _customersService.GetAll();
            if (result == null)
            {
                return NotFound("No data can be supplied!");
            }
            return Ok(result);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
