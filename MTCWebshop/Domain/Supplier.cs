using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTCWebshop.Domain
{
    public class Supplier
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(36)]
        public string UserID { get; set; }
        [Required(ErrorMessage ="Name can't be empty!")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "BTW can't be empty!")]
        [MaxLength(20)]
        public string BTW { get; set; }
        public string WebSite { get; set; }
        public bool IsActive { get; set; } = true;
        [Required(ErrorMessage = "Company number can't be empty!")]
        [MaxLength(20)]
        public string CompanyNummer { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<OrderIN> OrdersIN { get; set; }
    }
}
