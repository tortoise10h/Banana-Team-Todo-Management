using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.ViewModels
{
    public class TodoUpdateModel
    {
        public int TodoId { get; set; }
        public TodoInfoEditModel TodoInfo { get; set; }
        public List<UserViewModel> AllUsers { get; set; }
        public List<UserViewModel> Participants { get; set; }
        public List<UserViewModel> UsersNotInTodo { get; set; }
    }
}
