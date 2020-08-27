using System;
using System.ComponentModel.DataAnnotations;

namespace Minimal.Models
{
    public class Photo
    {
        [Key]
        public Guid Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual Product Product { get; set; }
        public Guid ProductId { get; set; }
        public virtual Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
