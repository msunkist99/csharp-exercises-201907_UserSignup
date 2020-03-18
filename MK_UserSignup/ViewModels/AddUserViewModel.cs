using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MK_UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [MinLength(6, ErrorMessage = "User name must be at least 6 characters")]
        [StringLength(15, ErrorMessage = "User name must be a maximum of 15 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Username { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [Required]
       [Compare(nameof(VerifyPassword),ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Verify Password")]
        public string VerifyPassword { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDateTime { get; set; }

    }
}
