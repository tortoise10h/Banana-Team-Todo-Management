using AutoMapper;
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
    public class ActivityServices : IActivityServices
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ActivityServices(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ActivityListViewModel> List(
            int page,
            int limit)
        {
            int skip = (page - 1) * limit;

            var activities = await _context.Activities
                .Skip(skip)
                .Take(limit)
                .ToListAsync();
            int totalActivities = await _context.Activities.CountAsync();
            int totalPage = (int)Math.Ceiling((double)totalActivities / limit);

            return new ActivityListViewModel
            {
                PageSize = limit,
                CurrentPage = page,
                Activites = _mapper.Map<List<ActivityViewModel>>(activities),
                TotalPage = totalPage,
                TotalRecord = totalActivities
            };
        }

        public async Task TrackActivity(
            string firstName,
            string lastName,
            string email,
            ActivityTypeEnum activityType,
            string description,
            string userId,
            DataContext ctx)
        {
            var activityEntity = new Activity
            {
                Description = description,
                UserId = userId,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                ActivityType = activityType
            };

            await ctx.Activities.AddAsync(activityEntity);
        }
    }
}
