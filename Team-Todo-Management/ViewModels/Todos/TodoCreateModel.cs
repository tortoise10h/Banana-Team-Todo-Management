using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class TodoCreateModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        [EnumDataType(typeof(TodoScopeEnum), ErrorMessage = "Scope of the task is invalid")]
        public TodoScopeEnum Scope { get; set; }
    }
}
