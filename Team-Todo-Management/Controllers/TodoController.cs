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
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TodoController(DataContext context, ITodoServices todoServices, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _todoServices = todoServices;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IActionResult> Inbox()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var result = await _todoServices.GetInboxTodos(currentUser);

            return View(result);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Messag = "Hello world bro";
            var tempTodo = new Todo
            {
                Id = 1,
                Name = "Login feature",
                Scope = TodoScopeEnum.Private
            };
            ViewBag.LuckyNumber = 10;

            return View(tempTodo);
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
                .SingleOrDefaultAsync(x => x.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            var users = await _context.Users.ToListAsync();

            TodoUpdateModel updateModel = new TodoUpdateModel
            {
                TodoInfo = _mapper.Map<TodoInfoEditModel>(todo),
                AllUsers = _mapper.Map<List<UserViewModel>>(users)
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
                try
                {
                    _mapper.Map<TodoInfoEditModel, Todo>(updateModel.TodoInfo, todo);
                    _context.Todos.Update(todo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoExists(todo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Inbox));
            }

            var users = await _context.Users.ToListAsync();
            updateModel.AllUsers = _mapper.Map<List<UserViewModel>>(users);
            return View(updateModel);
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
