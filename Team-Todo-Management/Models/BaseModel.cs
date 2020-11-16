using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.Models
{
    public class BaseModel
    {
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
