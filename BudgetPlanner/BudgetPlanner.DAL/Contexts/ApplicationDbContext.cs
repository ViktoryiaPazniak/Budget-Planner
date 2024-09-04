using BudgetPlanner.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

    }
}
