using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class ActivityQueryModel : BaseQueryModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ActivityTypeEnum ActivityType { get; set; }
    }
}