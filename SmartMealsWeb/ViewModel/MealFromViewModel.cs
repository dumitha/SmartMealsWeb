using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;

namespace SmartMealsWeb.ViewModel
{
    public class MealFromViewModel
    {
        public Meal Meal { get; set; }

        public IEnumerable<MealType> MealType { get; set; }


    }
}