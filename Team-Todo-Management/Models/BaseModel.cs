using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.Models
{
    public class BaseModel
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public string LastModifiedById { get; set; }
        public bool IsDeleted { get; set; }
    }
}
