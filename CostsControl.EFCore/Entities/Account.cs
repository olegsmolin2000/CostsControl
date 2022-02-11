using CostsControl.EFCore.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CostsControl.EFCore.Entities
{
    public class Account:Entity
    {
        [Required]
        public string Name { get; set; }
        public int Amount { get; set; }
        public HashSet<Transaction> Transactions { get; set; }
    }
}
