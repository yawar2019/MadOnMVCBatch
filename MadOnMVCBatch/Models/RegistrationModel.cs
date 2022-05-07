using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MadOnMVCBatch.Models
{
    public class RegistrationModel
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Name Cannot be Empty")]
        public string EmpName { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Pwd and Confirm Password must match")]
        public string ConfirmPassword { get; set; }

        public string Gender { get; set; }

        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [StringLength(10,ErrorMessage ="10 characters are Allowed")]
        public string Address { get; set; }
    }
}