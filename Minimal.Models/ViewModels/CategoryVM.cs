using System.Collections.Generic;

namespace Minimal.Models.ViewModels
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}