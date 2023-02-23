using RestaurantCRUD.Models;
using RestaurantCRUD.Services.Interfaces;

namespace RestaurantCRUD.Services
{
    public class CustomerService : ICustomerService
    {
        public Task<List<Customer>> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> UpdateCustomer(int id, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
