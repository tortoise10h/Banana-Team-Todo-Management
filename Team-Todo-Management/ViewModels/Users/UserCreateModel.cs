using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;

namespace Team_Todo_Management.ViewModels
{
    public class UserCreateModel
    {
        [Required(ErrorMessage = "Please enter first name")]
        [StringLength(255, ErrorMessage = "Name cannot be longer than 255 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        [StringLength(255, ErrorMessage = "Name cannot be longer than 255 characters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phonenumber")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [StringLength(255, MinimumLength = 8)]
        public string Password { get; set;  }
        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
