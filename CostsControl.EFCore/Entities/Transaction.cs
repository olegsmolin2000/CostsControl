using CostsControl.EFCore.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace CostsControl.EFCore.Entities
{
    public class Transaction:Entity
    {
        [Required]
        public Product Product { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public Account Account { get; set; }
    }
}