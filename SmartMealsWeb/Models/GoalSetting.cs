using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMealsWeb.Models
{
    public class GoalSetting
    {

        public byte Id { get; set; }
        public string Name { get; set; }
        //  public byte DurationInMonths { get; set; }


        public static readonly byte StayHealthy = 0;
        public static readonly byte GainMuscle = 1;
        public static readonly byte LoseWeight = 2;
        public static readonly byte Tone = 3;
        public static readonly byte EatHealthier = 4;
    }
}