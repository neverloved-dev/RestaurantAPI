using RestaurantCRUD.Models;

namespace RestaurantCRUD.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
        Task<List<Customer>> Get(int id);
        Task<List<Customer>> UpdateCustomer(int id,Customer customer);
        Task<List<Customer>> DeleteCustomer(int id);
    }
}
