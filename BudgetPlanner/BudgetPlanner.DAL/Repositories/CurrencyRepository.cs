using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Entities;
using BudgetPlanner.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Repositories
{
    public class CurrencyRepository : IRepository<CurrencyEntity>
    {
        private ApplicationDbContext _context;

        public CurrencyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(CurrencyEntity currency)
        {
            _context.Currencies.Add(currency);
            await _context.SaveChangesAsync();
        }

        public async Task Update(CurrencyEntity currency)
        {
            var dbCurrency = await _context.Currencies.FindAsync(currency.CurrencyId);

            if (dbCurrency == null)
            {
                throw new Exception("Unable to find the currency.");
            }

            dbCurrency.CurrencyName = currency.CurrencyName;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dbCurrency = await _context.Currencies.FindAsync(id);

            if (dbCurrency == null)
            {
                throw new Exception("Unable to find the currency.");
            }

            _context.Currencies.Remove(dbCurrency);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CurrencyEntity>> GetAll()
        {
            return await _context.Currencies.ToListAsync();
        }

        public async Task<CurrencyEntity> GetById(int id)
        {
            var currency = await _context.Currencies.FindAsync(id);

            if (currency == null)
            {
                throw new Exception("Unable to find the currency.");
            }

            return currency;
        }
    }
}
