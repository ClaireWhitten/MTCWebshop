using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    

    public class OrderIN
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Status can't be empty!")]
        public Status Status { get; set; } = Status.Reserved;
        public ICollection<OrderLineIN> OrderLinesIN { get; set; }
    }
}
