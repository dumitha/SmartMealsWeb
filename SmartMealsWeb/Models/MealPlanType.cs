using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMealsWeb.Models
{
    public class MealPlanType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
      //  public byte DurationInMonths { get; set; }


        public static readonly byte Unknown = 0;
        public static readonly byte Vegan = 1;
        public static readonly byte Vegetarian = 2;
        public static readonly byte Pescetarian = 3; 
        public static readonly byte Paleo = 4;


    }
}