using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Entities;
using BudgetPlanner.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            var dbUser = await _context.Users.FindAsync(user.UserId);

            if (dbUser == null)
            {
                throw new Exception("Unable to find the user.");
            }

            dbUser.Username = user.Username;
            dbUser.PasswordHash = user.PasswordHash;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dbUser = await _context.Users.FindAsync(id);

            if (dbUser == null)
            {
                throw new Exception("Unable to find the user.");
            }

            _context.Users.Remove(dbUser);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                throw new Exception("Unable to find the user.");
            }

            return user;
        }
    }
}
