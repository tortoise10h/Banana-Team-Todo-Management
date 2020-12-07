using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Models;

namespace Team_Todo_Management.IServices
{
    public interface IUserServices
    {
        Task<List<ApplicationUser>> GetUsersNotInTodo(int todoId);
        Task<List<ApplicationUser>> GetAllUsers();
    }
}
