using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DZ08.Models
{
    public class UserModels
    {
        [Required(ErrorMessage = "Please tell us your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please tell us your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please tell us your email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please set up your password")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Password is minimum 10 characters")]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please tell us your date of birth")]
        [Display(Name = "Birthday")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please tell us your gender")]
        public string Gender { get; set; }
    }
}