using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;
using System.ComponentModel.DataAnnotations;


namespace SmartMealsWeb.ViewModel
{
    public class MealFromViewModel
    {
       // public Meal Meal { get; set; }

        public IEnumerable<MealType> MealTypes { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }

        [Display(Name = "Meal Type")]
        [Required]
        public byte? MealTypeId { get; set; }

        //public string Type { get; set; }

        public string Description { get; set; }

        [Display(Name = "Date posted")]
        //public DateTime? DatePosted { get; set; }
        public DateTime DatePosted = DateTime.Now;


    }
}