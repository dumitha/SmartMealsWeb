using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartMealsWeb.Models
{
    public class Friend
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name="Username")]
        public string Name { get; set; }

        //will get initialized to 0
        public int Id { get; set; }

        
        [Display (Name = "Are you competing with friends?")]
        public bool IsCompetingWithOtherUsers { get; set; }
        
        public MealPlanType MealPlanType { get; set; }

        [Display(Name = "Meal Plan")]
        public byte MealPlanTypeID { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}