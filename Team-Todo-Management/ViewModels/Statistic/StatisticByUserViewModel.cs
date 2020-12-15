using System.Collections.Generic;

namespace Team_Todo_Management.ViewModels
{
    public class StatisticByUserViewModel
    {
        public List<TodoViewModel> Todos { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}