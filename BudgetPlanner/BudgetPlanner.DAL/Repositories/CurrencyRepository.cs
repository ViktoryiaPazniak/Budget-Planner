using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Entities;
using BudgetPlanner.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Repositories
{
    public class CurrencyRepository : IRepository<Currency>
    {
        private ApplicationDbContext _context;

        public CurrencyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Currency currency)
        {
            _context.Currencies.Add(currency);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Currency currency)
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

        public async Task<IEnumerable<Currency>> GetAll()
        {
            return await _context.Currencies.ToListAsync();
        }

        public async Task<Currency> GetById(int id)
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
