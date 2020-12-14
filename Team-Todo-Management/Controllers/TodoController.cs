using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
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
                    .ThenInclude(x => x.User)
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

            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            ViewBag.UserId = currentUser.Id;

            var medias = await _context.Medias
                .Where(x => x.TodoId == id)
                .ToListAsync();

            var todoListFileModels = _mapper.Map<List<TodoListFileModel>>(medias);

            foreach (var item in todoListFileModels)
            {
                var matchedMedia = medias.SingleOrDefault(x => x.Id == item.Id);

                item.FileName = Path.GetFileNameWithoutExtension(matchedMedia.Location);
                item.FileExtension = Path.GetExtension(matchedMedia.Location);
            }

            TodoDetailViewModel viewModel = new TodoDetailViewModel
            {
                TodoId = todo.Id,
                TodoInfo = _mapper.Map<TodoViewModel>(todo),
                AllUsers = _mapper.Map<List<UserViewModel>>(users),
                Participants = _mapper.Map<List<UserViewModel>>(usersInTodo),
                UsersNotInTodo = _mapper.Map<List<UserViewModel>>(usersNotInTodo),
                ListFiles = todoListFileModels
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

        public async Task<IActionResult> AssignedTasks()
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var result = await _todoServices.GetAssignedTasks(currentUser);

            return View(result);
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
                .Include(x => x.Participants)
                .SingleOrDefaultAsync(x => x.Id == id);

            if (todo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                if (todo.PersonInChargeId != currentUser.Id)
                {
                    var participantIds = todo.Participants
                        .Select(x => x.UserId);

                    if (!User.IsInRole(RoleNameEnum.Boss) &&
                        !participantIds.Contains(currentUser.Id))
                    {
                        return BadRequest("You don't have a permission to comment to this todo");
                    }
                }
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

        [HttpPost]
        public async Task<IActionResult> UploadFile([FromRoute] int id, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                TempData["Message"] = "Please select file";
                return RedirectToAction(nameof(Details), new { id });
            }

            var supportedContent = new[]
            {
                //Image
                "image/png",
                "image/jpeg",
                "image/x-citrix-jpeg",
                "image/pjpeg",
                "image/x-citrix-png",
                "image/x-png",
                //Compressed
                "application/x-rar-compressed",
                "application/zip",
                "application/x-tar",
                "application/x-7z-compressed",
                //Office
                "application/msword",
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                "application/vnd.ms-excel",
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "application/vnd.ms-powerpoint",
                "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                //Text
                "text/plain",
                "text/csv",
                //Pdf
                "application/pdf"
            };

            if (!supportedContent.Contains(file.ContentType))
            {
                TempData["Message"] = "Invalid file type";
                return RedirectToAction(nameof(Details), new { id });
            }

            string date = DateTime.Now.ToString("ddmmyyyyHHmmss");
            string extension = Path.GetExtension(file.FileName);
            string name = Path.GetFileNameWithoutExtension(file.FileName);
            string fullFileName = name + "_" + date + extension;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload", fullFileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var newMedia = new Media
            {
                TodoId = id,
                Filemime = file.ContentType,
                Location = Path.Combine("Upload", fullFileName)
            };

            _context.Medias.Add(newMedia);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Upload file successfully";
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> DownloadFile(int id)
        {
            var media = await _context.Medias.SingleOrDefaultAsync(x => x.Id == id);
            if (media == null)
            {
                return NotFound();
            }

            var fileFullName = Path.GetFileNameWithoutExtension(media.Location) + Path.GetExtension(media.Location);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload", fileFullName);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, media.Filemime, Path.GetFileName(path));
        }
    }
}
