using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;

namespace SmartMealsWeb.Dtos
{
    public class FriendDto
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        //will get initialized to 0
        public int Id { get; set; }


      
        public bool IsCompetingWithOtherUsers { get; set; }

        
        public byte MealPlanTypeID { get; set; }

      
      //  [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }



    }
}