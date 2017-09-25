using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartMealsWeb.Models
{
    public class Meal
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        [Display(Name = "Date posted")]
        //public DateTime? DatePosted { get; set; }
        public DateTime DatePosted = DateTime.Now;

        public MealType MealTypes { get; set; }
        [Display(Name = "Breakfast, Lunch or Dinner?")]
        public byte MealTypeID { get; set; }



    }
}