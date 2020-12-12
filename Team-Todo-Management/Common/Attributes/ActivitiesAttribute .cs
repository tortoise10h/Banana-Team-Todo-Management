using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.Common.Attributes
{
    public class ActivitiesAttribute: ResultFilterAttribute
    {
        private string _description;
        private string _userFullName;
        private string _userEmail;
        private string _userId; 
        private ActivityTypeEnum _activityType { get; set; }

        public ActivitiesAttribute(
            string description,
            string userFullName,
            string userEmail,
            string userId,
            ActivityTypeEnum activityType)
        {
            _description = description;
            _userFullName = userFullName;
            _userEmail = userEmail;
            _userId = userId;
            _activityType = activityType;
        }

        public override Task OnResultExecutionAsync(
            ResultExecutingContext context,
            ResultExecutionDelegate next)
        {
            return base.OnResultExecutionAsync(context, next);
        }
    }
}
