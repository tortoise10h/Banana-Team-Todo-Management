using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team_Todo_Management.Data;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Controllers
{
    [Authorize(Roles = "Boss")]
    public class StatisticController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;


        public StatisticController(DataContext context, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> StatisticByUser(
            [FromQuery] string id,
            [FromQuery] DateTime? fromDate,
            [FromQuery] DateTime? toDate
        )
        {
            var user = await _context.Users
                .SingleOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            var allUsers = await _context.Users.ToListAsync();
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);
            var participatedTodos = await _context.Participants
                .Where(x => x.UserId == id)
                .ToListAsync();
            var participatedTodoIds = participatedTodos.Select(x => x.TodoId);

            var queryable = _context.Todos.AsQueryable();

            if (fromDate != null)
            {
                queryable = queryable.Where(x => x.CreatedAt >= fromDate);
            }

            if (toDate != null)
            {
                queryable = queryable.Where(x => x.CreatedAt <= toDate);
            }

            var todos = await queryable
                .Where(x => x.PersonInChargeId == id ||
                    participatedTodoIds.Contains(x.Id))
                .Include(x => x.PersonInCharge)
                .ToListAsync();

            ViewBag.UserId = currentUser.Id;

            return Ok(new StatisticByUserViewModel
            {
                Todos = _mapper.Map<List<TodoViewModel>>(todos),
                Users = _mapper.Map<List<UserViewModel>>(allUsers)
            });
        }
    }
}