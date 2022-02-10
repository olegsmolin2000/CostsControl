using CostsControl.EFCore.Context;
using CostsControl.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CostsControl.EFCore.Repositories
{
    public class AccountsRepository : DbRepository<Account>
    {
        public AccountsRepository(CostsDB db) 
            : base(db) { }

        public override IQueryable<Account> ItemsInDataBase => base.ItemsInDataBase
            .Include(account => account.Transactions);

        public override IQueryable<Account> ItemsInMemory => base.ItemsInMemory
            .Include(account => account.Transactions);
    }
}
