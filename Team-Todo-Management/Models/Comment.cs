using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.Models
{
    [Table("Comment")]
    public class Comment: BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public int TodoId { get; set; }

        public ApplicationUser User { get; set; }
        public Todo Todo { get; set; }
    }
}
