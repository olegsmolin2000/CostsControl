using CostsControl.EFCore.Context;
using CostsControl.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CostsControl.EFCore.Repositories
{
    public class CategoriesRepository : DbRepository<Category>
    {
        public CategoriesRepository(CostsDB db) 
            : base(db) { }

        public override IQueryable<Category> ItemsInDataBase => base.ItemsInDataBase
            .Include(category => category.ParentCategory)
            .Include(category => category.Products);

        public override IQueryable<Category> ItemsInMemory => base.ItemsInMemory
            .Include(category => category.ParentCategory)
            .Include(category => category.Products);
    }
}
