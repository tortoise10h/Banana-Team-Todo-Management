using System;
using System.Collections.Generic;
using System.Linq;
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
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IActivityServices _activityServices;

        public UserController(DataContext context, UserManager<ApplicationUser> userManager, IMapper mapper, IHttpContextAccessor httpContextAccessor, IActivityServices activityServices)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _activityServices = activityServices;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var users = _userManager.Users;
            var userViewModels = _mapper.Map<List<UserViewModel>>(users);

            var userIds = users
                .Select(x => x.Id)
                .ToList();

            var userRoles = await _context.UserRoles
                .Where(x => userIds.Contains(x.UserId))
                .Join(_context.Roles,
                    ur => ur.RoleId,
                    r => r.Id,
                    (ur, r) => new
                    {
                        RoleName = r.Name,
                        ur.UserId
                    })
                .ToListAsync();

            foreach (var item in userViewModels)
            {
                var matchedUserRole = userRoles
                    .SingleOrDefault(x => x.UserId == item.Id);

                item.Role = matchedUserRole.RoleName;
            }

            return View(userViewModels.OrderBy(x => x.Role));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserCreateModel createModel)
        {
            if (ModelState.IsValid)
            {
                var hasher = new PasswordHasher<ApplicationUser>();
                ApplicationUser currentUser = await _userManager.GetUserAsync(User);
                var newUser = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = createModel.FirstName,
                    LastName = createModel.LastName,
                    UserName = createModel.Email,
                    NormalizedUserName = createModel.Email.ToUpper(),
                    Email = createModel.Email,
                    NormalizedEmail = createModel.Email.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, createModel.Password),
                    PhoneNumber = createModel.PhoneNumber,
                    SecurityStamp = string.Empty,
                    CreatedAt = DateTime.Now
                };

                var role = await _context.Roles
                .FirstOrDefaultAsync(r => r.Name == createModel.RoleName);

                var newUserRole = new IdentityUserRole<string>
                {
                    UserId = newUser.Id,
                    RoleId = role.Id
                };

                await _context.Users.AddAsync(newUser);
                await _context.UserRoles.AddAsync(newUserRole);

                await _activityServices.TrackActivity(
                    currentUser.FirstName,
                    currentUser.LastName,
                    currentUser.Email,
                    ActivityTypeEnum.CreateUser,
                    $"{newUser.LastName} {newUser.FirstName} ({newUser.Email}) with role {createModel.RoleName}",
                    currentUser.Id,
                    _context
                );

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }
            return View(createModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userRole = await _userManager.GetRolesAsync(user);

            UserUpdateModel updateModel = new UserUpdateModel
            {
                UserId = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                RoleName = userRole[0]
            };

            return View(updateModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, UserUpdateModel updateModel)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userRole = await _userManager.GetRolesAsync(user);
            if (ModelState.IsValid)
            {
                try
                {
                    ApplicationUser currentUser = await _userManager.GetUserAsync(User);

                    user.FirstName = updateModel.FirstName;
                    user.LastName = updateModel.LastName;
                    user.UserName = updateModel.Email;
                    user.NormalizedUserName = updateModel.Email.ToUpper();
                    user.Email = updateModel.Email;
                    user.NormalizedEmail = updateModel.Email.ToUpper();
                    user.PhoneNumber = updateModel.PhoneNumber;

                    await _userManager.RemoveFromRoleAsync(user, userRole[0]);
                    await _userManager.AddToRoleAsync(user, updateModel.RoleName);

                    await _activityServices.TrackActivity(
                        currentUser.FirstName,
                        currentUser.LastName,
                        currentUser.Email,
                        ActivityTypeEnum.UpdateUser,
                        $"{user.LastName} {user.FirstName} ({user.Email})",
                        currentUser.Id,
                        _context
                    );

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(List));
            }
            return View(updateModel);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userInTodos = await _context.Todos.FirstOrDefaultAsync(x => x.PersonInChargeId == user.Id);
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);

            if (userInTodos != null)
            {
                TempData["Message"] = "User " + user.Email + " has been already in use";
                return RedirectToAction(nameof(List));
            }

            var userInParticipants = await _context.Participants.FirstOrDefaultAsync(x => x.UserId == user.Id);
            if (userInParticipants != null)
            {
                TempData["Message"] = "User " + user.Email + " has been already in use";
                return RedirectToAction(nameof(List));
            }

            await _activityServices.TrackActivity(
                currentUser.FirstName,
                currentUser.LastName,
                currentUser.Email,
                ActivityTypeEnum.DeleteUser,
                $"{user.LastName} {user.FirstName} ({user.Email})",
                currentUser.Id,
                _context
            );

            await _context.SaveChangesAsync();

            await _userManager.DeleteAsync(user);

            TempData["Message"] = "Delete user " + user.Email + " successfully";
            return RedirectToAction(nameof(List));
        }
    }
}
