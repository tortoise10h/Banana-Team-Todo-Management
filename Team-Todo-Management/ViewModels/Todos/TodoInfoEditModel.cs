using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class TodoInfoEditModel
    {
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TodoStatusEnum Status { get; set; }
        public TodoScopeEnum Scope { get; set; }
        public string Description { get; set; }
        public string PersonInChargeId { get; set; }
    }
}
