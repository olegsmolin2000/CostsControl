using CostsControl.EFCore.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CostsControl.EFCore.Entities
{
    public class Category:Entity
    {
        public Category ParentCategory { get; set; }
        public HashSet<Category> Childs { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public HashSet<Product> Products { get; set; }
    }
}
