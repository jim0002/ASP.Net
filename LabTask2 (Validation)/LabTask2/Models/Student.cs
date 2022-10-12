using LabTask2.CustomValidatior;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabTask2.Models
{
    public class Student
    {
        [Required(ErrorMessage = " empty please provided name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be consist of at least 3 and maximum 50 characters")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Unsupported character in Name")]
        public string Name { get; set; }
        [Required]
        [IdValidation]
        public string Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [EmailValidation]
        [EmailAddress]
        //
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password must contain at least one Uppercase one lower case one special character and one number ")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm passowrd field sould not be empty")]
        [Compare("Password", ErrorMessage = "Password not match")]
        public string ConfPassword { get; set; }
        [Required(ErrorMessage = "Date of Birth is empty")]
        [DobValidation]
        public string Dob { get; set; }
    }
}