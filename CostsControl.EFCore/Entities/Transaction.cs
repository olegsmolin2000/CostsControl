using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsControl.EFCore.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}