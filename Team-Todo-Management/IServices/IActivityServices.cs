using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;
using Team_Todo_Management.Data;
using Team_Todo_Management.Models;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.IServices
{
    public interface IActivityServices
    {
        Task TrackActivity(
            string firstName,
            string lastName,
            string userEmail,
            ActivityTypeEnum activityType,
            string description,
            string userId,
            DataContext ctx);

        Task<PagedResultModel<ActivityViewModel>> List(ActivityQueryModel query);
    }
}
