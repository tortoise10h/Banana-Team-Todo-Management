using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Team_Todo_Management.Common.Enum;
using Team_Todo_Management.Data;
using Team_Todo_Management.IServices;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
        private readonly ITodoServices _todoServices;
        private readonly IUserServices _userServices;
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TodoController(DataContext context, ITodoServices todoServices, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager, IUserServices userServices)
        {
            _context = context;
            _todoServices = todoServices;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _userServices = userServices;
        }

        public async Task<IActionResult> Inbox()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var result = await _todoServices.GetInboxTodos(currentUser);

            return View(result);
        }

        public async Task<IActionResult> AllTasks()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var result = await _todoServices.GetAllTodos(currentUser);
            ViewBag.UserId = currentUser.Id;

            return View(result);
        }
        public async Task<IActionResult> TodayTasks()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var result = await _todoServices.GetTodayTodos(currentUser);

            return View(result);
        }

        public async Task<IActionResult> WeekTasks()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var result = await _todoServices.GetWeekTodos(currentUser);

            return View(result);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos
                .Include(x => x.PersonInCharge)
                .Include(x => x.Comments)
                .Include(x => x.Participants)
                .SingleOrDefaultAsync(x => x.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            var users = await _userServices.GetAllUsers();
            var userIdsInTodo = todo.Participants.Select(x => x.UserId);
            var usersInTodo = users.Where(x => userIdsInTodo.Contains(x.Id));
            var usersNotInTodo = users.Except(usersInTodo);

            TodoDetailViewModel viewModel = new TodoDetailViewModel
            {
                TodoId = todo.Id,
                TodoInfo = _mapper.Map<TodoViewModel>(todo),
                AllUsers = _mapper.Map<List<UserViewModel>>(users),
                Participants = _mapper.Map<List<UserViewModel>>(usersInTodo),
                UsersNotInTodo = _mapper.Map<List<UserViewModel>>(usersNotInTodo)
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TodoCreateModel createModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                var todoModel = _mapper.Map<Todo>(createModel);

                await _todoServices.Create(todoModel, currentUser);

                return RedirectToAction(nameof(Inbox));
            }
            return View(createModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos
                .Include(x => x.PersonInCharge)
                .Include(x => x.Participants)
                .SingleOrDefaultAsync(x => x.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            var users = await _userServices.GetAllUsers();
            var userIdsInTodo = todo.Participants.Select(x => x.UserId);
            var usersInTodo = users.Where(x => userIdsInTodo.Contains(x.Id));
            var usersNotInTodo = users.Except(usersInTodo);

            TodoUpdateModel updateModel = new TodoUpdateModel
            {
                TodoId = todo.Id,
                TodoInfo = _mapper.Map<TodoInfoEditModel>(todo),
                AllUsers = _mapper.Map<List<UserViewModel>>(users),
                Participants = _mapper.Map<List<UserViewModel>>(usersInTodo),
                UsersNotInTodo = _mapper.Map<List<UserViewModel>>(usersNotInTodo)
            };

            return View(updateModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TodoUpdateModel updateModel)
        {
            var todo = await _context.Todos
                .SingleOrDefaultAsync(x => x.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                await _todoServices.UpdateTodo(updateModel.TodoInfo, todo, currentUser, _context);
                return RedirectToAction(nameof(Inbox));
            }

            /** Prepare info for edit page when update process is failed */
            var participants = await _context.Participants
                .Where(x => x.TodoId == todo.Id)
                .ToListAsync();
            var users = await _userServices.GetAllUsers();
            var userIdsInTodo = participants.Select(x => x.UserId);
            var usersInTodo = users.Where(x => userIdsInTodo.Contains(x.Id));
            var usersNotInTodo = users.Except(usersInTodo);

            updateModel.TodoId = todo.Id;
            updateModel.AllUsers = _mapper.Map<List<UserViewModel>>(users);
            updateModel.UsersNotInTodo = _mapper.Map<List<UserViewModel>>(usersInTodo);
            updateModel.Participants = _mapper.Map<List<UserViewModel>>(usersNotInTodo);
            return View(updateModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddTodoParticipants(
            [FromRoute] int id,
            [FromBody] AddTodoParticipantsModel model)
        {
            var todo = await _context.Todos
                .SingleOrDefaultAsync(x => x.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                var result = await _todoServices.AddParticipantsToTodo(
                    currentUser,
                    model.SelectedUserIds,
                    todo);

                return Ok(result);
            }

            return RedirectToAction("Edit", new { id = todo.Id });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAParticipant(
            [FromRoute] string id,
            [FromBody] RemoveAParticipantFromTodoModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                var result = await _todoServices.RemoveAParticipantFromTodo(
                    currentUser,
                    model.TodoId,
                    id);

                return Ok(result);
            }
            else
            {
                return Ok(new AjaxResultViewModel(false, "There is something wrong, please try again"));
            }
        }

        [HttpPost]
        public async Task<IActionResult> ChangeStatusOfTodo(
            [FromRoute] int id,
            [FromBody] ChangeTodoStatusModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                var result = await _todoServices.ChangeStatusOfTodo(
                    id,
                    model.Status,
                    currentUser
                );

                return Ok(result);
            }
            else
            {
                return Ok(new AjaxResultViewModel(false, "There is something wrong, please try again"));
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(
            [FromRoute] int id,
            [FromForm] PostCommentModel model)
        {
            var todo = await _context.Todos
                .SingleOrDefaultAsync(x => x.Id == id);

            if (todo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                await _todoServices.PostCommentToTodo(
                    model.CommentContent,
                    currentUser,
                    todo
                );

                return RedirectToAction(nameof(Details), new { id });
            }

            return View(model);
        }

        // GET: Todoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await _context.Todos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        // POST: Todoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TodoExists(int id)
        {
            return _context.Todos.Any(e => e.Id == id);
        }
    }
}
