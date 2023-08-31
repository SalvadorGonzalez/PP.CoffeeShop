using PP.CoffeeShop.Presentation.Data;

namespace PP.CoffeeShop.Presentation.Business.Services
{
    public interface IDrinkService
    {
        public List<Drink> GetDrinks();
        public Drink GetDrink(int id);
    }
}
