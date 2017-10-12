using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Data.Entity;
using System.Web.Http;
using SmartMealsWeb.Dtos;
using SmartMealsWeb.Models;

namespace SmartMealsWeb.Controllers.Api 
{

    public class MealsController : ApiController
    {
        private ApplicationDbContext _context;

        public MealsController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<MealDto> GetMeals(string query = null)
        {
            var mealsQuery = _context.Meals
                .Include(m => m.Description);

            if (!String.IsNullOrWhiteSpace(query))
                mealsQuery = mealsQuery.Where(m => m.Name.Contains(query));

            return mealsQuery
                .ToList()
                .Select(Mapper.Map<Meal, MealDto>);
                
        }

        public IHttpActionResult GetMeal(int id)
        {
            var meal = _context.Meals.SingleOrDefault(m => m.Id == id);

            if (meal == null)
                return NotFound();

            return Ok(Mapper.Map<Meal, MealDto>(meal));
        }

        [HttpPost]
       // [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateMeal(MealDto mealDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var meal = Mapper.Map<MealDto, Meal>(mealDto);
            _context.Meals.Add(meal);
            _context.SaveChanges();

            mealDto.Id = meal.Id;
            return Created(new Uri(Request.RequestUri + "/" + meal.Id), mealDto);
        }

        [HttpPut]
       // [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult EditMeal(int id, MealDto mealDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var mealInDb = _context.Meals.SingleOrDefault(m => m.Id == id);

            if (mealInDb == null)
                return NotFound();

            Mapper.Map(mealDto, mealInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult DeleteMeal(int id)
        {
            var mealInDb = _context.Meals.SingleOrDefault(m => m.Id == id);

            if (mealInDb == null)
                return NotFound();

            _context.Meals.Remove(mealInDb);
            _context.SaveChanges();

            return Ok();
        }
    }





}