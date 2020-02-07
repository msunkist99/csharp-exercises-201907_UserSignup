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
        public string Username { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [Compare(nameof(VerifyPassword),ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Verify Password")]
        public string VerifyPassword { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDateTime { get; set; }

    }
}
