using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Data
{
    public class Grades
    {
        [Key]
        public int Id { get; set; }
        
        public string StudentClass { get; set; }
    }
}
