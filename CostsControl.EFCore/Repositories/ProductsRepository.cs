using CostsControl.EFCore.Context;
using CostsControl.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CostsControl.EFCore.Repositories
{
    public class ProductsRepository : DbRepository<Product>
    {
        public ProductsRepository(CostsDB db) 
            : base(db) { }

        public override IQueryable<Product> ItemsInDataBase => base.ItemsInDataBase
            .Include(product => product.Categories)
            .Include(product => product.Transactions);

        public override IQueryable<Product> ItemsInMemory => base.ItemsInMemory
            .Include(product => product.Categories)
            .Include(product => product.Transactions);
    }
}
