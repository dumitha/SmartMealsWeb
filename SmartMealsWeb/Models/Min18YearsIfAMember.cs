using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartMealsWeb.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var friend = (Friend)validationContext.ObjectInstance;
            //friend.MealPlanTypeID == MealPlanType.Unknown
            if (friend.IsCompetingWithOtherUsers==false)
               
                return ValidationResult.Success;

            if (friend.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - friend.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("User should be at least 18 years old to compete with other friends.");




        }
    }
}