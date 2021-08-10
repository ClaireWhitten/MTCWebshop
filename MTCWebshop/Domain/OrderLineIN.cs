using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class OrderLineIN
    {
        public int ID { get; set; }
        public int OrderINID { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Qtt can't be less than 1 !")]
        public int Quantity { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Qtt can't be less than 0 !")]
        public double UnitPrice { get; set; }
        public Status Status { get; set; } = Status.Reserved;
    }
}
