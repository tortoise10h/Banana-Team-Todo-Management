using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.Models
{
    [Table("Activity")]
    public class Activity: BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public ActivityTypeEnum ActivityType { get; set; }

        public ApplicationUser User { get; set; }
    }
}
