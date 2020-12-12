﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Data;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.IServices
{
    public interface ITodoServices
    {
        Task Create(Todo todo, ApplicationUser currentUser);
        Task<List<TodoViewModel>> GetInboxTodos(ApplicationUser currentUser);
        Task<AjaxResultViewModel> AddParticipantsToTodo(
            ApplicationUser currentUser,
            List<string> selectedUserIds,
            Todo todo);
        Task<AjaxResultViewModel> RemoveAParticipantFromTodo(
            ApplicationUser currentUser,
            int todoId,
            string participantUserId);
        Task<List<TodoViewModel>> GetTodayTodos(ApplicationUser currentUser);
        Task UpdateTodo(
            TodoInfoEditModel updatedInfo,
            Todo oldTodo,
            ApplicationUser user,
            DataContext ctx);
    }
}
