using CostsControl.EFCore.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CostsControl.EFCore.Entities
{
    public class Category:Entity
    {
        public Category ParentCategory { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
