using System.Collections.Generic;

namespace Team_Todo_Management.ViewModels
{
    public class TodoDetailViewModel
    {
        public int TodoId { get; set; }
        public TodoViewModel TodoInfo { get; set; }
        public List<UserViewModel> AllUsers { get; set; }
        public List<UserViewModel> Participants { get; set; }
        public List<UserViewModel> UsersNotInTodo { get; set; }
        public List<TodoListFileModel> ListFiles { get; set; }
    }
}