using AspMealTask.Entities;
using AspMealTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspMealTask.Controllers
{
    public class HomeController : Controller
    {

        public List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Coca Cola",
                    ImagePath="~/Image/cocacola.png"
                },
                new Drink
                {
                    Id=2,
                    Name="Fanta",
                    ImagePath="~/Image/fanta.png"
                },
                new Drink
                {
                    Id=3,
                    Name="Pepsi",
                    ImagePath="~/Image/pepsi.png"
                },
                new Drink
                {
                    Id=4,
                    Name="Milk",
                    ImagePath="~/Image/milk.png"
                }
            };

        public List<Meal> meals = new List<Meal>
            {
                new Meal
                {
                    Id=1,
                    Name="Kend Colbasi",
                    ImagePath="~/Image/kendcolbasi.png"
                },
                new Meal
                {
                    Id=2,
                    Name="Makaron",
                    ImagePath="~/Image/makaron.png"
                },
                new Meal
                {
                    Id=3,
                    Name="Kabab",
                    ImagePath="~/Image/kabab.png"
                },
                new Meal
                {
                    Id=4,
                    Name="Ash-qara",
                    ImagePath="~/Image/ashqara.png"
                }
            };

        public List<FastFood> fastfoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Pizza",
                    ImagePath="~/Image/pizza.png"
                },
                new FastFood
                {
                    Id=2,
                    Name="Kartof Free",
                    ImagePath = "~/Image/kartoffree.png"
                },
                new FastFood
                {
                    Id=3,
                    Name="Doner",
                    ImagePath = "~/Image/doner.png"
                },
                new FastFood
                {
                    Id=4,
                    Name="Nuggets",
                    ImagePath = "~/Image/nuggets.png"
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


        public IActionResult HotMeal()
        {


            return View(meals);
        }

        public IActionResult FastFood()
        {


            return View(fastfoods);
        }


    }
}
