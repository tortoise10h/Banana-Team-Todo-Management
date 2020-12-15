using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.Common.Enum
{
    public enum ActivityTypeEnum
    {
        CreateTodo = 1,
        UpdateTodo = 2,
        AddParticipantsToTodo = 3,
        RemoveAParticipantFromTodo = 4,
        CreateUser = 5,
        UpdateUser = 6,
        DeleteUser = 7,
        PostComment = 8,
        DeleteComment = 9,
        UploadFile = 10,
    }
}
