using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.IServices
{
    public interface ITodoServices
    {
        Task Create(Todo todo, ApplicationUser currentUser);
        Task<List<TodoViewModel>> GetInboxTodos();
    }
}
