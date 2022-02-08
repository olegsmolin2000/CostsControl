using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsControl.EFCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
