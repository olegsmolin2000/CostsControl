using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CostsControl.EFCore.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
