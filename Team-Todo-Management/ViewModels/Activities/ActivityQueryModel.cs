using System;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class ActivityQueryModel : BaseQueryModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public ActivityTypeEnum ActivityType { get; set; }
    }
}