using Microsoft.AspNetCore.Mvc;
using PP.CoffeeShop.Presentation.Business.Services;
using PP.CoffeeShop.Presentation.Models.ViewModels;

namespace PP.CoffeeShop.Presentation.Controllers
{
    public class DrinksController : Controller
    {
        private readonly IDrinkService _drinkService;

        public DrinksController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public IActionResult Index(int drinkCategory)
        {
            //if (drinkCategory == null || drinkCategory <= 0) { }
            var model = new DrinkCategoryViewModel();

            var category = _drinkService.GetDrinkCategory(drinkCategory);

            if (category == null)
            {
                return NotFound();
            }
            model.CategoryName = category.Name;
            
            var hotCoffees = _drinkService.GetDrinksByCategory(drinkCategory);
            model.Drinks = hotCoffees;

            return View(model);
        }

        //public IActionResult HotCoffees(int drinkCategory)
        //{
        //    var hotCoffees = _drinkService.GetDrinksByCategory(drinkCategory);
        //    return View(hotCoffees);
        //}
    }
}
