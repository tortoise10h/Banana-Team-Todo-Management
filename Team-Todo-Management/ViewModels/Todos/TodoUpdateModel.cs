using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.ViewModels
{
    public class TodoUpdateModel
    {
        public TodoInfoEditModel TodoInfo { get; set; }
        public List<UserViewModel> AllUsers { get; set; }
    }
}
