using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.Models
{
    [Table("Log")]
    public class Log: BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public string UserId { get; set; }
        public LogTypeEnum LogType { get; set; }

        public ApplicationUser User { get; set; }
    }
}
