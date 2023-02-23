using Microsoft.AspNetCore.Mvc;
using RestaurantCRUD.Models;
using RestaurantCRUD.Services.Interfaces;
namespace RestaurantCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService) 
        {
            _orderService = orderService;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<ActionResult<List<Order>>> Get()
        {
           var result = _orderService.GetAllOrders();
            if(result == null)
            {
                return NotFound("Data cannot be supplied");
            }
            return Ok(result);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Order>>> Get(int id)
        {
            return null;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult<List<Order>>> Post([FromBody] string value)
        {
            return null;
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Order>>> Put(int id, [FromBody] string value)
        {
            return null;
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Order>>> Delete(int id)
        {
            return null;
        }
    }
}
