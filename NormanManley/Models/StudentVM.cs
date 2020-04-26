using Microsoft.AspNetCore.Mvc.Rendering;
using NormanManley.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Models
{
    public class StudentVM
    {
        [Key]
        public int Id { get; set; }

        [Required]

        [Display(Name = "Student First  Name")]

        public string StudentFirstName { get; set; }

        [Required]

        [Display(Name = "Student Last  Name")]

        public string StudentLastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string Disabilities { get; set; }

        [Required]
        public string Grade { get; set; }

        [Required]
        public string Gender { get; set; }
    

        [Required]

        [Display(Name = "Parent First Name")]
        public string ParentFirstName { get; set; }
        [Required]

        [Display(Name = "Parent Last  Name")]

        public string ParentLastName { get; set; }
        


        [Display(Name = "Gaurdian First  Name")]

        public string GuardianFirstName { get; set; }


        [Display(Name = "Gaurdian Last  Name")]

       
        public string GuardianLastName { get; set; }
        

    }
}
    


