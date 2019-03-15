using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Testlogin.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter ID")]
        [MaxLength(16)]
        [MinLength(8)]
        public String ID { get; set; }

        [Display(Name = "Password")]
        [MaxLength(16)]
        [MinLength(8)]
        [Required(ErrorMessage = "Please enter Password ")]
        [DataType(DataType.Password)]
        public String PW { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please enter Password ")]
        [DataType(DataType.Password)]
        [Compare("PW")]
        public String ConfirmPW { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter First Name ")]
        public String Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter Last Name ")]
        public String Lastname { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Please enter Email")]
        public String email { get; set; }

        [Required(ErrorMessage = "Please enter Age")]
        [MaxLength(2)]
        public int? Age { get; set; }
    }
}