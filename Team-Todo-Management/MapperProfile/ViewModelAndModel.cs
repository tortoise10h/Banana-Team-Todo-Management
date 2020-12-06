using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.MapperProfile
{
    public class ViewModelAndModel: Profile
    {
        public ViewModelAndModel()
        {
            /** Todo */
            CreateMap<Todo, TodoCreateModel>();
            CreateMap<TodoCreateModel, Todo>();

            CreateMap<Todo, TodoViewModel>();
            CreateMap<TodoViewModel, Todo>();

            /** User */
            CreateMap<ApplicationUser, UserViewModel>();
            CreateMap<UserViewModel, ApplicationUser>();
        }
    }
}
