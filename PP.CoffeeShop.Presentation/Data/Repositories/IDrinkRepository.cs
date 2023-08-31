namespace PP.CoffeeShop.Presentation.Data.Repositories
{
    public interface IDrinkRepository
    {
        public List<Drink> GetDrinks();
        public Drink GetDrink(int id);
    }
}
