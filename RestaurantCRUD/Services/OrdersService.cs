using RestaurantCRUD.Models;
using RestaurantCRUD.Services.Interfaces;

namespace RestaurantCRUD.Services
{
    public class OrdersService : IOrderService
    {
        public Task<List<Order>> DeleteOrder(int order_id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrder(int order_id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrders(int[] order_ids)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> UpdateOrder(int order_id, Order order)
        {
            throw new NotImplementedException();
        }
    }
}
