using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Entities;
using BudgetPlanner.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Repositories
{
    public class WalletRepository : IRepository<WalletEntity>
    {
        private ApplicationDbContext _context;

        public WalletRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(WalletEntity wallet)
        {
            _context.Wallets.Add(wallet);
            await _context.SaveChangesAsync();
        }

        public async Task Update(WalletEntity wallet)
        {
            var dbWallet = await _context.Wallets.FindAsync(wallet.WalletId);

            if (dbWallet == null)
            {
                throw new Exception("Unable to find the wallet.");
            }

            dbWallet.Name = wallet.Name;
            dbWallet.Amount = wallet.Amount;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dbWallet = await _context.Wallets.FindAsync(id);

            if (dbWallet == null)
            {
                throw new Exception("Unable to find the wallet.");
            }

            _context.Wallets.Remove(dbWallet);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<WalletEntity>> GetAll()
        {
            return await _context.Wallets.ToListAsync();
        }

        public async Task<WalletEntity> GetById(int id)
        {
            var wallet = await _context.Wallets.FindAsync(id);

            if (wallet == null)
            {
                throw new Exception("Unable to find the wallet.");
            }

            return wallet;
        }
    }
}
