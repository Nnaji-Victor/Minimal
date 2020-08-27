using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Minimal.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public double OldPrice { get; set; }

        [Required]
        public int Stocks { get; set; }

        public double Ratings { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
