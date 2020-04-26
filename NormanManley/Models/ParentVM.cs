using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Models
{
    public class ParentVM
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string MotherFirstName { get; set; }
        [Required]
        public string MotherLastName { get; set; }
        [Required]
        public string FatherFirstName { get; set; }
        [Required]
        public string FatherLastName { get; set; }
        [Required]
        public string GuardianFirstName { get; set; }
        [Required]
        public string GuardianLastName { get; set; }
    }
}
    

