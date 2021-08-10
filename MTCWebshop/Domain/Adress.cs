using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Adress
    {
        public int ID {get; set; }
        [Required(ErrorMessage = "Street can't be empty")]
        [MaxLength(50)]
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
        [Required]
        [MaxLength(36)]
        public string UserID { get; set; }
        
        public override string ToString()
        {
            return $"{Street} {HouseNumber}/{BusNumber}, {PostCode} {City}, {Land}.";
        }
    }
}
