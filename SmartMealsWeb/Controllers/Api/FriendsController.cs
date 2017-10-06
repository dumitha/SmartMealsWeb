using SmartMealsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using AutoMapper;
using System.Web.Http;
using SmartMealsWeb.Dtos;


namespace SmartMealsWeb.Controllers.Api
{
    public class FriendsController : ApiController
    {

        private ApplicationDbContext _context;

        public FriendsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/friends
        public IHttpActionResult GetFriends(string query = null)
        {
            //return _context.Friends.ToList().Select(Mapper.Map<Friend, FriendDto>);

            var friendsQuery = _context.Friends
               .Include(f => f.MealPlanType);

            if (!String.IsNullOrWhiteSpace(query))
                friendsQuery = friendsQuery.Where(f => f.Name.Contains(query));

            var customerDtos = friendsQuery
                .ToList()
                .Select(Mapper.Map<Friend, FriendDto>);

            return Ok(customerDtos);
        }

        // GET /api/friends/1
        public IHttpActionResult GetFriend(int id)
        {
            var friend = _context.Friends.SingleOrDefault(f => f.Id == id);

            if (friend == null)
                return NotFound();

            return Ok (Mapper.Map<Friend, FriendDto>(friend));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateFriend(FriendDto friendDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var friend = Mapper.Map<FriendDto, Friend>(friendDto);
            _context.Friends.Add(friend);
            _context.SaveChanges();

            friendDto.Id = friend.Id;

            return Created(new Uri(Request.RequestUri + "/" + friend.Id), friendDto);

        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateFriend(int id, FriendDto friendDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var friendInDb = _context.Friends.SingleOrDefault(f => f.Id == id);

            if (friendInDb == null)
                return NotFound();
            Mapper.Map(friendDto, friendInDb);

            _context.SaveChanges();
            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteFriend(int id)
        {
            var friendInDb = _context.Friends.SingleOrDefault(f => f.Id == id);

            if (friendInDb == null)
                return NotFound();


            _context.Friends.Remove(friendInDb);
            _context.SaveChanges();

            return Ok();


        }
    }
}
