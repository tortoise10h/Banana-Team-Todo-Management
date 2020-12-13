using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Todo_Management.ViewModels
{
    public class UserUpdateModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        [StringLength(255, ErrorMessage = "Name cannot be longer than 255 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        [StringLength(255, ErrorMessage = "Name cannot be longer than 255 characters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter phonenumber")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
