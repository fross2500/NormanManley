using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Data
{
    public class Parent : IdentityUser
    {
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }
        public string FatherFirstName { get; set; }
        public string FatherLastName { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
    }
}
