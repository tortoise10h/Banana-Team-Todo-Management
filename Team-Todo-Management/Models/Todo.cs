using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enums;

namespace Team_Todo_Management.Models
{
    public class Todo: BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TodoStatusEnum Status { get; set; }
        public TodoScopeEnum Scope { get; set; }
    }
}
