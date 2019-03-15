using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Testlogin.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter Username")]
        public String Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter Password ")]
        public String Password { get; set; }
    }
}