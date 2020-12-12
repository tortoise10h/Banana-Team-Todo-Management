using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class ActivityViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

        [Display(Name = "Type")]
        public ActivityTypeEnum ActivityType { get; set; }

        [Display(Name = "At a time")]
        public DateTime CreatedAt { get; set; }
    }
}
