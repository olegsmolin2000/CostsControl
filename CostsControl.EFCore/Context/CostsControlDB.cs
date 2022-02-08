using CostsControl.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CostsControl.EFCore.Context
{
    public class CostsControlDB:DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=TestDB;user=Oleg;password=Zhopa123456");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
