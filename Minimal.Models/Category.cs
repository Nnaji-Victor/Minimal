using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Minimal.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual Photo Photo { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}