using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NormanManley.Models
{
    public class DetailPaymentVM
    {
        [Required]
        public string Paymentmethod { get; set; }
        [Required]
        public string TypeOfPayment { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public DateTime CardExpiration { get; set; }
    }
}

public class CreatePaymentVM
{
    [Required]
    public string Paymentmethod { get; set; }
    [Required]
    public string TypeOfPayment { get; set; }
    [Required]
    public int CardNumber { get; set; }
    [Required]
    public DateTime CardExpiration { get; set; }
}