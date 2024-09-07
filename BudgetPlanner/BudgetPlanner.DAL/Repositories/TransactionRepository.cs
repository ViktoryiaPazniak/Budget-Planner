using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Entities;
using BudgetPlanner.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Repositories
{
    public class TransactionRepository : IRepository<TransactionEntity>
    {
        private ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(TransactionEntity transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TransactionEntity transaction)
        {
            var dbTransaction = await _context.Transactions.FindAsync(transaction.TransactionId);

            if (dbTransaction == null)
            {
                throw new Exception("Unable to find the transaction.");
            }

            dbTransaction.TransactionName = transaction.TransactionName;
            dbTransaction.CategoryId = transaction.CategoryId;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dbTransaction = await _context.Transactions.FindAsync(id);

            if (dbTransaction == null)
            {
                throw new Exception("Unable to find the transaction.");
            }

            _context.Transactions.Remove(dbTransaction);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TransactionEntity>> GetAll()
        {
            return await _context.Transactions.ToListAsync();
        }

        public async Task<TransactionEntity> GetById(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                throw new Exception("Unable to find the transaction.");
            }

            return transaction;
        }
    }
}
