using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.ViewModels
{
    public class TodoEditModel
    {
        public TodoInfoEditModel TodoInfo { get; set; }
        public UserViewModel User { get; set; }
    }
}
