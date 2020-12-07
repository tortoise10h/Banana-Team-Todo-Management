using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class TodoInfoEditModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name="Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name="End Date")]
        public DateTime? EndDate { get; set; }

        [Required]
        [EnumDataType(typeof(TodoStatusEnum), ErrorMessage = "Status of the task is invalid")]
        public TodoStatusEnum Status { get; set; }

        [Required]
        [EnumDataType(typeof(TodoScopeEnum), ErrorMessage = "Scope of the task is invalid")]
        public TodoScopeEnum Scope { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name="Person In Charge")]
        public string PersonInChargeId { get; set; }

        public UserViewModel PersonInCharge { get; set; }
    }
}
