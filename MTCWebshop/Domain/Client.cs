using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        public ICollection<OrderOUT> OrderOUTs { get; set; }


        //foreign key

        [MaxLength(36)]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Bonus> Bonuses { get; set; }

       
    }
}
