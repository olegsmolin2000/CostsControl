using CostsControl.EFCore.Entities.Base;

namespace CostsControl.EFCore.Entities
{
    public class Transaction:Entity
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
        public Account Account { get; set; }
    }
}