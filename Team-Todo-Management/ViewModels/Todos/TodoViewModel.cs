using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class TodoViewModel
    {
        public TodoStatusEnum Status { get; set; }
        public TodoScopeEnum Scope { get; set; }
        public List<CommentViewModel> Comments { get; set; }
        public UserViewModel PersonInCharge { get; set; }
        public string PersonInChargeId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StatusName
        {
            get
            {
                if (Status == TodoStatusEnum.New)
                {
                    return "New";
                }
                else if (Status == TodoStatusEnum.Processing)
                {
                    return "Processing";
                }
                else if (Status == TodoStatusEnum.Done)
                {
                    return "Done";
                }
                else if (Status == TodoStatusEnum.Overdue)
                {
                    return "Overdue";
                }
                else
                {
                    return "Cancelled";
                }
            }
        }
        public string ScopeName
        {
            get
            {
                if (Scope == TodoScopeEnum.Private)
                {
                    return "Private";
                }
                else
                {
                    return "Public";
                }
            }
        }

        public string PersonInChargeName
        {
            get
            {
                return PersonInCharge.FullName;
            }
        }
        public DateTime CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public string LastModifiedById { get; set; }
    }
}
