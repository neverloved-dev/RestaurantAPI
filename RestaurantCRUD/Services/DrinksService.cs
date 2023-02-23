using RestaurantCRUD.Services.Interfaces;
using RestaurantCRUD.Models;
namespace RestaurantCRUD.Services
{
    public class DrinksService : IDrinksService
    {
       public Task<List<Drink>> GetAllDrinks()
        {
            throw new NotImplementedException();
        }

       public Task<List<Drink>> GetOneDrink(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Drink>> UpdateDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public Task<List<Drink>> DeleteDrink(int id)
        {
            throw new NotImplementedException();
        }
    }
}
