using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Data;
using Team_Todo_Management.IServices;
using Team_Todo_Management.Models;

namespace Team_Todo_Management.Services
{
    public class UserServices : IUserServices
    {
        private readonly DataContext _context;

        public UserServices(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationUser>> GetUsersNotInTodo(int todoId)
        {
            var usersInTodo = await _context.Participants
                .Where(x => x.TodoId == todoId)
                .ToListAsync();
            var userIdsInTodo = usersInTodo.Select(x => x.UserId);

            var usersNotInTodo = await _context.Users
                .Where(x => !userIdsInTodo.Contains(x.Id))
                .ToListAsync();

            return usersNotInTodo;
        }

        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
