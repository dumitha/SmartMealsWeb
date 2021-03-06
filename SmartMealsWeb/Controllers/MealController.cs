﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMealsWeb.Models;
using SmartMealsWeb.ViewModel;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace SmartMealsWeb.Controllers
{
    public class MealController : Controller
    {
        private ApplicationDbContext _context;

        public MealController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Meal/ViewMeals

        public ViewResult Index()
        {
            //var meals = _context.Meals.Include(m => m.MealType).ToList();


            if (User.IsInRole(RoleName.CanManageMeals))
                return View("List");
            return View("ReadOnlyList");
        }

       

        [Authorize(Roles = RoleName.CanManageMeals)]
        public ViewResult NewMeal()
        {
            //get a list of the meal types first 
            var mealTypes = _context.MealTypes.ToList();
            var viewModel = new MealFromViewModel
            {
               
                MealTypes = mealTypes

            };


            return View("MealForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Meal meal)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new MealFromViewModel
                {
                  
                    MealTypes = _context.MealTypes.ToList()

                };
                return View("MealFrom", viewModel);
            }
            if (meal.Id == 0)
            {

                //in memory only 
                meal.DatePosted = DateTime.Now;

                _context.Meals.Add(meal);
            }

            else
            {
                var mealDbContext = _context.Meals.Single(m => m.Id == meal.Id);
                mealDbContext.Name = meal.Name;
                mealDbContext.MealTypeID = meal.MealTypeID;
                mealDbContext.Description = meal.Description;
                mealDbContext.DatePosted = meal.DatePosted;

            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }


            //rederict user back to list of meals
            //"Index" in Meals Controller
            return RedirectToAction("Index", "Meals");
        }



        public ActionResult Edit(int id)
        {
            var meal = _context.Meals.SingleOrDefault(m => m.Id == id);
            if (meal == null)
                return HttpNotFound(); //standard 404 error

            var MealViewModel = new MealFromViewModel()
            {
               
                MealTypes = _context.MealTypes.ToList()
            };
            return View("MealForm", MealViewModel);

        }


    }


 }
