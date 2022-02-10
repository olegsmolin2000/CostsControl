using CostsControl.EFCore.Context;
using CostsControl.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CostsControl.EFCore.Repositories
{
    public class TransactionsRepository : DbRepository<Transaction>
    {
        public TransactionsRepository(CostsDB db) 
            : base(db) { }

        public override IQueryable<Transaction> ItemsInDataBase => base.ItemsInDataBase
            .Include(transaction => transaction.Product)
            .Include(transaction => transaction.Account);

        public override IQueryable<Transaction> ItemsInMemory => base.ItemsInMemory
            .Include(transaction => transaction.Product)
            .Include(transaction => transaction.Account);
    }
}
