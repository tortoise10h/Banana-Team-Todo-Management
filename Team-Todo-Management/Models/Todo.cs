using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.Models
{
    [Table("Todo")]
    public class Todo: BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TodoStatusEnum Status { get; set; }
        public TodoScopeEnum Scope { get; set; }

        public ApplicationUser CreatedBy { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Media> Medias { get; set; }
        public ICollection<Participant> Participants { get; set; }
    }
}
