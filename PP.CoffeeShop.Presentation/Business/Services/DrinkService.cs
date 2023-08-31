using PP.CoffeeShop.Presentation.Data;
using PP.CoffeeShop.Presentation.Data.Repositories;

namespace PP.CoffeeShop.Presentation.Business.Services
{
    public class DrinkService : IDrinkService
    {
        private readonly IDrinkRepository _repository;

        public DrinkService(IDrinkRepository drinkRepository)
        {
            _repository = drinkRepository;
        }

        public Drink GetDrink(int id)
        {
            var result = _repository.GetDrink(id);
            return result;
        }

        public List<DrinkCategory> GetDrinkCategories()
        {
            return _repository.GetDrinkCategories();
        }

        public List<Drink> GetDrinks()
        {
            var result = _repository.GetDrinks();
            return result;
        }

        public List<Drink> GetDrinksByCategory(int categoryId)
        {
            var result = _repository.GetDrinksByCategory(categoryId);
            return result;
        }
    }
}
