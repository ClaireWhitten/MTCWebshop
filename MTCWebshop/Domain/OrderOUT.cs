using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class OrderOUT
    {
        public int Id { get; set;}

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Status Status { get; set; } = Status.Reserved; 

        //order address
        public string Street { get; set; }
        [Required(ErrorMessage = "House number can't be empty")]
        [MaxLength(4)]
        public int HouseNumber { get; set; }
        [MaxLength(6)]
        public string BusNumber { get; set; }
        [Required(ErrorMessage = "Postal code can't be empty")]
        [MaxLength(10)]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "City can't be empty")]
        [MaxLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Land can't be empty")]
        [MaxLength(50)]
        public string Land { get; set; }
        [MaxLength(10)]
        public double Latitude { get; set; }
        [MaxLength(10)]
        public double Longitude { get; set; }



        //foreign key 
        [Required(ErrorMessage = "Client cannot be empty")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public ICollection<OrderLineOUT> OrderLineOUTs { get; set; }




}
}
