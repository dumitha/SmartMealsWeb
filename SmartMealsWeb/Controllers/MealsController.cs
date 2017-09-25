using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMealsWeb.Models;
using SmartMealsWeb.ViewModel;

namespace SmartMealsWeb.Controllers
{
    public class MealsController : Controller
    {
        private ApplicationDbContext _context;

        public MealsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Meal/ViewMeals
        public ActionResult Index()
        {
            var meals = new List<Meal>{
                new Meal {
                    Name = "Banana Smoothie",
                    Type = "Breakfast",
                    Description = "Bannanas, almond milk, and honey"},
                new Meal
                {
                    Name ="Salmon with veggies",
                    Type = "Lunch",
                    Description = "Wild salmon with broccoli, carrots, and cabage" }
            };

            var viewMealsModel = new MealViewModel
            {
                Meals = meals
            };
            return View(viewMealsModel);
        }
        public ActionResult PostMeal(Meal meal)
        {
            //in memory only 
            _context.Meals.Add(meal);
            _context.SaveChanges();

            //rederict user back to list of meals
            //"ViewMeals" in Meals Controller
            return RedirectToAction("ViewMeals", "Meals");
            
        }
        public ViewResult NewMeal()
        {
            //get a list of the meal types first 
            var mealTypes = _context.MealTypes.ToList();
            var viewModel = new MealFromViewModel
            {
                Meal = new Meal(),
               
            };


            return View("MealForm");
        }
    }
}