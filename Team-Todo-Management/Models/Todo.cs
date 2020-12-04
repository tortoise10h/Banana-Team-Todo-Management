using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.Models
{
    public class Todo: BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TodoStatusEnum Status { get; set; }
        public TodoScopeEnum Scope { get; set; }

        public ApplicationUser Creator { get; set; }
    }
}
