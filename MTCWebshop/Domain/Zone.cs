using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Zone
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Zone name cannot be empty")]
        [MaxLength(60)]
        public string Name { get; set;}
    }
}
