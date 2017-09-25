using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SmartMealsWeb.Models;
namespace SmartMealsWeb.ViewModel
{
    public class FriendViewModel
    {
        public Friend friend { get; set; }
        public List<Friend> friends { get; set; }
    }
}