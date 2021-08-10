using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class ProductCategorie
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Name can't be Empty")]
        [MaxLength(50)]
        public string Name { get; set; }
        public ProductCategorie ParentCategorie { get; set; }
        public ICollection<ProductCategorie> SubCategories { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
