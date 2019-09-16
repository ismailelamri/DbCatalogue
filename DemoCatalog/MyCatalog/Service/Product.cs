using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCatalog.Service
{
    [Table("PRODUIT")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [StringLength(70)]
        [Required]
        [MinLength(4),MaxLength(70)]
        public string Designation { get; set; }
        [Range(10,5000000)]
        public double price { get; set; }
        public int Quantite { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }





    }
}
