using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Todo> Todos { get; set; }
        public ICollection<Participant> Participants { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
