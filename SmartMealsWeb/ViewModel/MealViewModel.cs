using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;


namespace SmartMealsWeb.ViewModel
{
    public class MealViewModel
    {
        public Meal Meal { get; set; }
        public List<Meal> Meals {get; set ;}
    }
}