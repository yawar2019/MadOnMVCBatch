using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MadOnMVCBatch.Models
{
    public class RegistrationModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }

        public string Country { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
    }
}