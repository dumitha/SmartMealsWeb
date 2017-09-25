using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMealsWeb.Models
{
    public class MealType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        //  public byte DurationInMonths { get; set; }


        public static readonly byte Breakfast = 0;
        public static readonly byte Lunch = 1;
        public static readonly byte Dinner = 2;
        public static readonly byte Snack = 3;
        public static readonly byte CheatMeal = 4;



    }
}