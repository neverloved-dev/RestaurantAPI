using RestaurantCRUD.Models;

namespace RestaurantCRUD.Services.Interfaces
{
    public interface IMealsService
    {
        Task<List<Meal>> GetAll();
        Task<List<Meal>> Get(int id);
        Task<List<Meal>> Update(int id, Meal meal);
        Task <List<Meal>> Delete(int id);
    }
}
