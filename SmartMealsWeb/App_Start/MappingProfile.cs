using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SmartMealsWeb.Dtos;
using SmartMealsWeb.Models;


namespace SmartMealsWeb.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            // Domain to Dto
            CreateMap<Friend, FriendDto>();
            CreateMap<Meal, MealDto>();
            CreateMap<MealPlanType, MealPlanTypeDto>();
            CreateMap<MealType, MealTypeDto>();


            // Dto to Domain
            CreateMap<FriendDto, Friend>()
                .ForMember(f => f.Id, opt => opt.Ignore());

            CreateMap<MealDto, Meal>()
                .ForMember(m => m.Id, opt => opt.Ignore());


        }
    }
}