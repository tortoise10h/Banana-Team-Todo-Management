using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

        public async Task<AjaxResultViewModel> AddParticipantsToTodo(
            ApplicationUser currentUser,
            List<string> selectedUserIds,
            Todo todo)
        {

            /** Only allow user who own this todo or boss can add participant to this todo */
            if (currentUser.Id != todo.PersonInChargeId)
            {
                bool isBoss = await _userManager.IsInRoleAsync(
                    currentUser,
                    RoleNameEnum.Boss);
                if (!isBoss)
                {
                    return new AjaxResultViewModel(false, "You don't have a permission to add participants to this task");
                }
            }

            /** Prevent user add himself/herself as a participant of his/her task */
            if (selectedUserIds.Any(x => x == currentUser.Id))
            {
                return new AjaxResultViewModel(false, "You can't add you as a participant of your own task");
            }

            /** Make sure new participants are valid */
            // exist in db
            var usersToAdd = await _context.Users
                .Where(x => selectedUserIds.Contains(x.Id))
                .ToListAsync();
            if (usersToAdd.Count != selectedUserIds.Count)
            {
                return new AjaxResultViewModel(false, "New participants are invalid");
            }

            // already in todo
            var participantsOfTodo = await _context.Participants
                .Where(x => x.TodoId == todo.Id &&
                    selectedUserIds.Contains(x.UserId))
                .ToListAsync();
            if (participantsOfTodo.Count > 0)
            {
                return new AjaxResultViewModel(false, "Some users are already in this task");
            }

            /** Create new participant for the todo */
            List<Participant> newParticipants = new List<Participant>();
            foreach (var userId in selectedUserIds)
            {
                newParticipants.Add(
                    new Participant
                    {
                        UserId = userId,
                        TodoId = todo.Id
                    });
            }

            await _context.Participants.AddRangeAsync(newParticipants);
            await _context.SaveChangesAsync();

            return new AjaxResultViewModel(true, "");
        }
    }
}
