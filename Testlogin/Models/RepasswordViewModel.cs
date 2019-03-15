using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Testlogin.Models
{
    public class RepasswordViewModel
    {
        public String username { get ; set ; }

        [Display(Name = "Password")]
        [MaxLength(16)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Password ")]
        public String Password { get; set; }

        [Display(Name = "New Password")]
        [MaxLength(16)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter New Password ")]
        public String NewPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Confirm Password ")]
        [Compare("NewPassword")]
        public String ConfirmPassword { get; set; }
    }
}