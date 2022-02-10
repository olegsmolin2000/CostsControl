using CostsControl.EFCore.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CostsControl.EFCore.Entities
{
    public class Product:Entity
    {
        [Required]
        public string Name { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
