using RestaurantCRUD.Models;
using RestaurantCRUD.Services.Interfaces;

namespace RestaurantCRUD.Services
{
    public class MealsService : IMealsService
    {
        public Task<List<Meal>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Meal>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Meal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Meal>> Update(int id, Meal meal)
        {
            throw new NotImplementedException();
        }
    }
}
