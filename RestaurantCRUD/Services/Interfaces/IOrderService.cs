using RestaurantCRUD.Models;

namespace RestaurantCRUD.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrders();
        Task<List<Order>> GetOrders(int[] order_ids);
        Task<List<Order>> GetOrder(int order_id);
        Task<List<Order>> UpdateOrder(int order_id, Order order);
        Task<List<Order>> DeleteOrder(int order_id);
    }
}
