using CostsControl.EFCore.Entities.Base;
using System.Collections.Generic;

namespace CostsControl.EFCore.Entities
{
    public class Account:Entity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
