﻿using Microsoft.AspNetCore.Mvc;
using PP.CoffeeShop.Presentation.Business.Services;

namespace PP.CoffeeShop.Presentation.Controllers
{
    public class MenuController : Controller
    {
        private readonly IDrinkService _drinkService;

        public MenuController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public IActionResult Index()
        {
            var drinks = _drinkService.GetDrinks();
            return View(drinks);
        }

        public IActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var drink = _drinkService.GetDrink(id);
            return View(drink);
        }
    }
}