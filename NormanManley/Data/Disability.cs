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
        public string Blind { get; set; }
        public string Dumb { get; set; }
        public string VisuallyImpaired { get; set; }
        public string PhysicallyDisabled { get; set; }
        public string HearingImpaired { get; set; }

    }
}
