using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Product

    {
        [Key]
        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        public string EAN { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        public string ExtraInfo { get; set; }

        [Required]
        [Range(0,30)]
        public double BTWPercentage { get; set; }


        public int Count { get; set; }

        public int MaxStock { get; set; }

        public int MinStock { get; set; }


        ICollection<string> ImageURLs { get; set; }


        [Range(0,5)]
        public double AverageRating { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double RecommendedUnitPrice { get; set; }

        
        public double? SolderPrice { get; set; }




        //foreign key
        [Required(ErrorMessage = "Category cannot be empty")]
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }


        public ICollection<Supplier> Suppliers { get; set; }

        public ICollection<OrderlineOut> OrderLineOUTs { get; set; }

        public ICollection<OrderlineIn> OrderLineINs { get; set; }

        public ICollection<ProductReview> ProductReview { get; set; }

       

    }
}
