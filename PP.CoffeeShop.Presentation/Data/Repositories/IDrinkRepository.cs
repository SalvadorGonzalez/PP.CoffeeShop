namespace PP.CoffeeShop.Presentation.Data.Repositories
{
    public interface IDrinkRepository
    {
        public List<Drink> GetDrinks();
        public Drink GetDrink(int id);
        public List<DrinkCategory> GetDrinkCategories();
        public List<Drink> GetDrinksByCategory(int categoryId);
    }
}
