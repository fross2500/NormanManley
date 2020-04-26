using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Data
{
    public class Gender
    {
        [Key]

        public int Id { get; set; }
        public string Boy { get; set; }
        public string Girl { get; set; }
    }
}
