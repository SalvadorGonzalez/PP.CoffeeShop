using PP.CoffeeShop.Presentation.Data;

namespace PP.CoffeeShop.Presentation.Models.ViewModels
{
    public class DrinkCategoryViewModel
    {
        public string CategoryName { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
