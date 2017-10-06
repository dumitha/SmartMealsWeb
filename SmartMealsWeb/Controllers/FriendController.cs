using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMealsWeb.ViewModel;
using SmartMealsWeb.Models;
using System.Data.Entity.Validation;

namespace SmartMealsWeb.Controllers
{
    public class FriendController : Controller
    {
        private ApplicationDbContext _context;

        public FriendController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Friend/Index
        public ViewResult Index()
        {
            var friends = _context.Friends.Include(f => f.MealPlanType).ToList();


            return View(friends);
        }

       public ActionResult FriendProfile(int id)
        {
            var friend = _context.Friends.SingleOrDefault(u => u.Id == id);

            if (friend == null)
                return HttpNotFound();

            var viewModel = new FriendFormViewModel
            {
                Friend = friend,
                MealPlanType = _context.MealPlanTypes.ToList()


            };

            return View("FriendProfile", viewModel);
        }                       

        public ViewResult FriendsSearch(string searchCriteria)
        {

            var FriendsList = new List<Friend>();

            try
            {
                FriendsList = _context.Friends.Where(F => F.Name.Contains(searchCriteria)).ToList();


            }
            catch (Exception ex)
            {
                string err = ex.Message;
                throw;
            }


            return View("FriendsSearch", FriendsList);
        }

        public ViewResult NewFriend()
        {
            //get a list of the meal types first 
            var mealTypes = _context.MealPlanTypes.ToList();
            var viewModel = new FriendFormViewModel
            {
                Friend = new Friend(),
                MealPlanType = mealTypes
            };
            return View("FriendForm",viewModel);
        }



        //Can only be called using http post & never using http get
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Friend friend)
        {
            if (!ModelState.IsValid)
            {
               
                    var viewModel = new FriendFormViewModel
                    {
                        Friend = friend,
                        MealPlanType = _context.MealPlanTypes.ToList()

                    };
                    return View("FriendFrom", viewModel);
            }
            if(friend.Id == 0)
            
                //in memory only 
                _context.Friends.Add(friend);
            
            else
            {
                var friendDbContext = _context.Friends.Single(f => f.Id == friend.Id);
                friendDbContext.Name = friend.Name;
                friendDbContext.Birthdate = friend.Birthdate;
                friendDbContext.MealPlanType = friend.MealPlanType;
                friendDbContext.IsCompetingWithOtherUsers = friend.IsCompetingWithOtherUsers;
            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                Console.WriteLine(e);
            }
            
            
            //rederict user back to list of friends
            //"Index" in Friends Controller
            return RedirectToAction("Index", "Friends");
        }

        public ActionResult Edit(int id)
        {
            var friend = _context.Friends.SingleOrDefault(f => f.Id == id);
            if (friend == null)
                return HttpNotFound(); //standard 404 error

            var FriendViewModel = new FriendFormViewModel()
            {
                Friend = friend,

                MealPlanType = _context.MealPlanTypes.ToList()
            };
            return View("FriendForm", FriendViewModel);

        }

    }


}