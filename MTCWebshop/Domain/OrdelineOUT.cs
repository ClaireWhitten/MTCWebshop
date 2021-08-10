using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class OrdelineOUT
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Quantity cannot be empty")]
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "Unit Price cannot be empty")]
        [Range(0, double.MaxValue)]
        public double UnitPrice { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Reserved;


        //foreign key
        [Required(ErrorMessage = "Transporter cannot be empty")]
        public int TransporterId { get; set; }
        public Transporter Transporter { get; set; }



        //foreign key
        
        [Required(ErrorMessage = "Product cannot be empty")]
        public string ProductEAN { get; set; }
        public Product Product { get; set; }


        //foreign Key
        [Required(ErrorMessage = "Product cannot be empty")]
        public int OrderOUTId { get; set; }
        public OrderOUT OrderOUT { get; set; }

   



}
}
