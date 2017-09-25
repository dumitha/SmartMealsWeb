using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;

namespace SmartMealsWeb.ViewModel
{
    public class FriendFormViewModel
    {
        public IEnumerable<MealPlanType> MealPlanType { get; set; }

        public Friend Friend { get; set;}
    }
}