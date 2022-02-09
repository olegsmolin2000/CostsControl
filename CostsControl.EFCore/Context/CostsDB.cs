using CostsControl.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CostsControl.EFCore.Context
{
    public class CostsDB:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=TestDB;user=Oleg;password=Zhopa123456";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
