using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Transporter
    {

        public int Id { get; set; }

        [Required(ErrorMessage="Name cannot be empty")]
        public string Name { get; set; }

        public ICollection<Zone> Zones { get; set; }

        //foreign key
        [Required]
        [MaxLength(36)]
        public int UserId { get; set; }
        public User user { get; set; }


    }
}
