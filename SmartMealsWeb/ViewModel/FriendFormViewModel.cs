using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartMealsWeb.ViewModel
{
    public class FriendFormViewModel
    {
        public IEnumerable<MealPlanType> MealPlanType { get; set; }

        public Friend Friend { get; set;}

        [Display(Name = "What's your goal?!")]
        public GoalSetting GoalSetting { get; set; }


        public IEnumerable<GoalSetting> GoalSettings { get; set; }

        public byte? GoalSettingId { get; set; }
    }
}