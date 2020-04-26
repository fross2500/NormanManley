using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Data
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public string Paymentmethod { get; set; }
        public string TypeOfPayment { get; set; }
        public int CardNumber { get; set; }
        public DateTime CardExpiration { get; set; }
    }
    
}

