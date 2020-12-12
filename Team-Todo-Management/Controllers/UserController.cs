using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team_Todo_Management.Data;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(DataContext context, UserManager<ApplicationUser> userManager, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
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

            return View(userViewModels);
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
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }
            return View(createModel);
        }
    }
}
