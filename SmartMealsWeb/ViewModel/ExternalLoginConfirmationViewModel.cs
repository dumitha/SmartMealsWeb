using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartMealsWeb.ViewModel
{
    public class ExternalLoginConfirmationViewModel
    {

       
            [Required]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Display(Name = "Your phone number")]
            public string PhoneNumberFriend { get; set; }

            [Required]
            [Display(Name = "Are you competing with friends?")]
            public bool IsCompetingWithOtherUsers { get; set; }

        }
    }
