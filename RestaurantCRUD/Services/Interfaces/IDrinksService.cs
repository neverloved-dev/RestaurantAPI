using RestaurantCRUD.Models;

namespace RestaurantCRUD.Services.Interfaces
{
    public interface IDrinksService
    {
        Task<List<Drink>> GetAllDrinks();
        Task<List<Drink>> GetOneDrink(int id);
        Task<List<Drink>> UpdateDrink(Drink drink);
        Task<List<Drink>> DeleteDrink(int id);
    }
}
