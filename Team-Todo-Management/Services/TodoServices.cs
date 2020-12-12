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
        private readonly IActivityServices _activityServices;

        public TodoServices(
            UserManager<ApplicationUser> userManager,
            DataContext context,
            IMapper mapper,
            IActivityServices activityServices)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
            _activityServices = activityServices;
        }

        public async Task Create(Todo todo, ApplicationUser currentUser)
        {
            todo.Status = TodoStatusEnum.New;
            todo.PersonInChargeId = currentUser.Id;

            await _context.Todos.AddAsync(todo);

            await _activityServices.TrackActivity(
                currentUser.FirstName,
                currentUser.LastName,
                currentUser.Email,
                ActivityTypeEnum.CreateTodo,
                $"{todo.Name}",
                currentUser.Id,
                _context
            );

            await _context.SaveChangesAsync();
        }

        public async Task UpdateTodo(
            TodoInfoEditModel updatedInfo,
            Todo oldTodo,
            ApplicationUser currentUser,
            DataContext ctx)
        {
            string oldName = oldTodo.Name;
            oldTodo.Name = updatedInfo.Name;
            oldTodo.StartDate = updatedInfo.StartDate;
            oldTodo.EndDate = updatedInfo.EndDate;
            oldTodo.PersonInChargeId = updatedInfo.PersonInChargeId;
            oldTodo.Description = updatedInfo.Description;
            oldTodo.Status = updatedInfo.Status;
            oldTodo.Scope = updatedInfo.Scope;
            // _mapper.Map<TodoInfoEditModel, Todo>(updatedInfo, oldTodo);
            ctx.Todos.Update(oldTodo);

            await _activityServices.TrackActivity(
                currentUser.FirstName,
                currentUser.LastName,
                currentUser.Email,
                ActivityTypeEnum.UpdateTodo,
                $"{oldName}",
                currentUser.Id,
                ctx
            );

            await ctx.SaveChangesAsync();
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

        public async Task<List<TodoViewModel>> GetTodayTodos(ApplicationUser currentUser)
        {
            DateTime startOfTheDay = DateTime.Today;
            DateTime tomorrow = DateTime.Today.AddDays(1);

            var listOfTodo = await _context.Todos
                .Where(x => x.PersonInChargeId == currentUser.Id &&
                    x.StartDate >= startOfTheDay &&
                    x.StartDate < tomorrow)
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
            string activityDescription = "";
            List<Participant> newParticipants = new List<Participant>();
            foreach (var userId in selectedUserIds)
            {
                /** For activity description */
                var user = usersToAdd.SingleOrDefault(x => x.Id == userId);
                activityDescription += $"{user.LastName} {user.FirstName} ({user.Email}), ";

                newParticipants.Add(
                    new Participant
                    {
                        UserId = userId,
                        TodoId = todo.Id
                    });
            }


            /** Remove the last 2 redundant characters after loop: comma (,) and space ( ) */
            activityDescription = activityDescription.Substring(0, activityDescription.Length - 2);
            activityDescription += $" to the task \"{todo.Name}\"";

            await _context.Participants.AddRangeAsync(newParticipants);
            await _activityServices.TrackActivity(
                currentUser.FirstName,
                currentUser.LastName,
                currentUser.Email,
                ActivityTypeEnum.AddParticipantsToTodo,
                activityDescription,
                currentUser.Id,
                _context
            );
            await _context.SaveChangesAsync();

            return new AjaxResultViewModel(true, "");
        }

        public async Task<AjaxResultViewModel> RemoveAParticipantFromTodo(
            ApplicationUser currentUser,
            int todoId,
            string participantUserId)
        {
            /** Make sure valid participant */
            var participant = await _context.Participants
                .Include(x => x.Todo)
                .Include(x => x.User)
                .SingleOrDefaultAsync(x => x.UserId == participantUserId &&
                    x.TodoId == todoId);

            if (participant == null)
            {
                return new AjaxResultViewModel(false, "A selected participant does not exist");
            }

            /** Make sure user who request is valid  
              only allow user who is person in charge and boss */
            if (participant.Todo.PersonInChargeId != currentUser.Id)
            {
                bool isBoss = await _userManager.IsInRoleAsync(currentUser, RoleNameEnum.Boss);
                if (!isBoss)
                {
                    return new AjaxResultViewModel(false, "You don't have a permission to remove a participant of this task");
                }
            }

            string activityDescription = $"{participant.User.LastName} {participant.User.FirstName} ";
            activityDescription += $"({participant.User.Email}) from the task ";
            activityDescription += $"\"{participant.Todo.Name}\"";

            await _activityServices.TrackActivity(
                            currentUser.FirstName,
                            currentUser.LastName,
                            currentUser.Email,
                            ActivityTypeEnum.RemoveAParticipantFromTodo,
                            activityDescription,
                            currentUser.Id,
                            _context
                        );
            _context.Participants.Remove(participant);
            await _context.SaveChangesAsync();

            return new AjaxResultViewModel(true, "");
        }
    }
}
