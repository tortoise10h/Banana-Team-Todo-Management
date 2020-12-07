using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;
using Team_Todo_Management.Data;
using Team_Todo_Management.IServices;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Services
{
    public class TodoServices : ITodoServices
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TodoServices(UserManager<ApplicationUser> userManager, DataContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task Create(Todo todo, ApplicationUser currentUser)
        {
            todo.Status = TodoStatusEnum.New;
            todo.PersonInChargeId = currentUser.Id;

            await _context.Todos.AddAsync(todo);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TodoViewModel>> GetInboxTodos(ApplicationUser currentUser)
        { 
            var listOfTodo = await _context.Todos
                .Where(x => x.PersonInChargeId == currentUser.Id)
                .Include(x => x.PersonInCharge)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            var todoViewModels = _mapper.Map<List<TodoViewModel>>(listOfTodo);

            return todoViewModels;
        }
    }
}
