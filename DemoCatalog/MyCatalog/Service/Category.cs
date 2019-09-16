using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCatalog.Service
{
    [Table("CATEGORIES")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(30)]
        [Required]
        [MinLength(4), MaxLength(30)]
        public string Categoryname { get; set; }
        public virtual ICollection<Product> Products { get; set; } // chargement dans la base (mode lazy)
    }
}
