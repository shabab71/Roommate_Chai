using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeRental.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage ="Enter your name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage="Enter Email")]
        [Display(Name ="Email address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Please Enter valid Email")]
        
        
        public string Email { get; set;  }

        [Required(ErrorMessage = "Enter Password")]
        [Compare("ConfirmPassword",ErrorMessage="Passwords don't match!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Pasword")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
