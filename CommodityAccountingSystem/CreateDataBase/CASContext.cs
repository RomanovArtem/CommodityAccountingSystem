using Models;
using System.Data.Entity;

namespace CreateDataBase
{
    public class CASContext : DbContext
    {
        public CASContext() : base(@"Data Source=DESKTOP-G95ITR8\SQLEXPRESS;Initial Catalog=CAS_Base;Integrated Security=True") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(string.Empty);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<HistoryPrice> HistoryPrices { get; set; }
        public DbSet<HistorySales> HistorySales { get; set; }
        public DbSet<IncomeAndExpense> IncomeAndExpenses { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
