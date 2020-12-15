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

        public async Task<PagedResultModel<ActivityViewModel>> List(ActivityQueryModel query)
        {
            int skip = (query.Page - 1) * query.Limit;

            var queryable = _context.Activities.AsQueryable();

            if (!string.IsNullOrEmpty(query.FirstName))
            {
                queryable = queryable.Where(x => x.FirstName.Contains(query.FirstName));
            }

            if (!string.IsNullOrEmpty(query.LastName))
            {
                queryable = queryable.Where(x => x.LastName.Contains(query.LastName));
            }

            if (query.ActivityType != 0)
            {
                queryable = queryable.Where(x => x.ActivityType == query.ActivityType);
            }

            if (query.FromDate != null)
            {
                queryable = queryable.Where(x => x.CreatedAt >= query.FromDate);
            }

            if (query.ToDate != null)
            {
                queryable = queryable.Where(x => x.CreatedAt <= query.ToDate);
            }

            var activities = await queryable
                .OrderByDescending(x => x.CreatedAt)
                .Skip(skip)
                .Take(query.Limit)
                .ToListAsync();

            int totalActivities = await queryable.CountAsync();
            int totalPage = (int)Math.Ceiling((double)totalActivities / query.Limit);

            return new PagedResultModel<ActivityViewModel>
            {
                PageSize = query.Limit,
                CurrentPage = query.Page,
                Data = _mapper.Map<List<ActivityViewModel>>(activities),
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
