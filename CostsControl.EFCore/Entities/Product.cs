using CostsControl.EFCore.Entities.Base;
using System.Collections.Generic;

namespace CostsControl.EFCore.Entities
{
    public class Product:Entity
    {
        public string Name { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
