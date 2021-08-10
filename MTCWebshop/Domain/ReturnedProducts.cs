using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class ReturnedProduct
    {
        public int ID { get; set; }
        public string EAN { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Qtt can't be less than 1 !")]
        public int Quantity { get; set; }
        public int OrderLineOUTID { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(1000,ErrorMessage ="A reason must be given!")]
        public Reason Reason { get; set; }
        public bool Outlet { get; set; }
        public int NewOrderLineOUTID { get; set; }

    }
}
