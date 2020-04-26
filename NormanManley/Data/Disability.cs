using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Data
{
    public class Disabilities
    {
        [Key]
        public int Id { get; set; }
        public string StudentDisability { get; set; }
        
    }
}
