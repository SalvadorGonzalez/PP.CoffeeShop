using Microsoft.EntityFrameworkCore;

namespace PP.CoffeeShop.Presentation.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _db;

        public DrinkRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Drink GetDrink(int id)
        {
            //var result = _db.Drinks.Find(id);
            var result = _db.Drinks.Include(category => category.Category).ToList().Find(x => x.Id == id);
            return result;
        }

        public List<Drink> GetDrinks()
        {
            var result = _db.Drinks.ToList();
            return result;
        }
    }
}
