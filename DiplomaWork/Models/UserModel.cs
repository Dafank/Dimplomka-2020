using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DiplomaWork.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First name is required!")]
        [StringLength(15, ErrorMessage = "First name is too long!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(15, ErrorMessage = "Last name is too long!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [MinLength(5, ErrorMessage = "Username must be at least 5 characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress()]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters!")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Re-type password is required!")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again!")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
