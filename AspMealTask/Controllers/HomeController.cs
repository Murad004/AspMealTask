using AspMealTask.Entities;
using AspMealTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMealTask.Controllers
{
    public class HomeController : Controller
    {

        public List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Coca Cola"
                },
                new Drink
                {
                    Id=2,
                    Name="Fanta"
                },
                new Drink
                {
                    Id=3,
                    Name="Pepsi"
                },
                new Drink
                {
                    Id=4,
                    Name="Milk"
                }
            };

        public List<Meal> meals = new List<Meal>
            {
                new Meal
                {
                    Id=1,
                    Name="Kend Colbasi"
                },
                new Meal
                {
                    Id=2,
                    Name="Makaron"
                },
                new Meal
                {
                    Id=3,
                    Name="Kabab"
                },
                new Meal
                {
                    Id=4,
                    Name="Ash-qara"
                }
            };

        public List<FastFood> fastfoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Pizza"
                },
                new FastFood
                {
                    Id=2,
                    Name="Kartof Free"
                },
                new FastFood
                {
                    Id=3,
                    Name="Doner"
                },
                new FastFood
                {
                    Id=4,
                    Name="Nuggets"
                }
            };
        public IActionResult Index()
        {
            var model = new MealsViewModel
            {
                Drinks = drinks,
                Meals = meals,
                FastFoods = fastfoods
            };



            return View(model);
        }



        public IActionResult Drink()
        {

            

            return View(drinks);
        }



    }
}
