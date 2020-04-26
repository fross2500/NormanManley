using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Models
{
    public class DetailStudentVM
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Disability { get; set; }
        
        [Required]
        public string Gender { get; set; }
        public string Grade { get; set; }
        public IEnumerable<SelectListItem> Disabilities { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; }
        public IEnumerable<SelectListItem> Grades { get; set; }
    }
}

public class CreateStudentVM
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public string Disability { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public string Grade { get; set; }

}