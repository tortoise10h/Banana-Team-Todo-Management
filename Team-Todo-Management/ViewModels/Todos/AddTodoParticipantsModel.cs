using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.ViewModels
{
    public class AddTodoParticipantsModel
    {
        [Required]
        public List<string> SelectedUserIds { get; set; }
    }
}
