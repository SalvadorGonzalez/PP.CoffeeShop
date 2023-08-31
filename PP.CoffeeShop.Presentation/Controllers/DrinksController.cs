using Microsoft.AspNetCore.Mvc;
using PP.CoffeeShop.Presentation.Business.Services;

namespace PP.CoffeeShop.Presentation.Controllers
{
    public class DrinksController : Controller
    {
        private readonly IDrinkService _drinkService;

        public DrinksController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HotCoffees(int drinkCategory)
        {
            var hotCoffees = _drinkService.GetDrinksByCategory(drinkCategory);
            return View(hotCoffees);
        }
    }
}
