using AspMealTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMealTask.Models
{
    public class MealsViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<Meal> Meals { get; set; }
        public List<FastFood> FastFoods { get; set; }

    }
}
