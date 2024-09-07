using BudgetPlanner.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<WalletEntity> Wallets { get; set; }

    }
}
