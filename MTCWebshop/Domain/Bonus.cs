using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Bonus
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public bool IsPercentage { get; set; }
        [Required]
        [Range(0.1,double.MaxValue,ErrorMessage ="Value must be more than 0!")]
        public double Value { get; set; }
        public int ClientID { get; set; }
        
    }
}
