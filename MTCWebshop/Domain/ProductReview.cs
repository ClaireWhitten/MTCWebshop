using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class ProductReview
    {
        public int Id { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        [Required]
        [Range(0,5)]
        public int Rating { get; set; }

        [Required]
        public DateTime DateTime { get; set; }



        //foreign key
        [ForeignKey("Product")]
        public string ProductEAN { get; set; }

        public Product Product { get; set; }


        //foreign key
        [Required(ErrorMessage ="User cannot be empty")]
        [MaxLength(36)]
        public string UserId { get; set; }

        public User User { get; set; }







    }
}
