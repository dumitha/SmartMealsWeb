using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;
using System.ComponentModel.DataAnnotations;


namespace SmartMealsWeb.Dtos
{
    public class MealDto
    {

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Id { get; set; }

        //public string Type { get; set; }

        public string Description { get; set; }

        
        //public DateTime? DatePosted { get; set; }
        public DateTime DatePosted = DateTime.Now;

        public MealType MealType { get; set; }

        
        public byte MealTypeID { get; set; }




    }
}