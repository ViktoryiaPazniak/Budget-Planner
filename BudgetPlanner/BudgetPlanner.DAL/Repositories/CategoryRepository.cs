using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Entities;
using BudgetPlanner.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner.DAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Category category)
        {
            var dbCategory = await _context.Categories.FindAsync(category.CategoryId);

            if (dbCategory == null)
            {
                throw new Exception("Unable to find the category.");
            }

            dbCategory.Name = category.Name;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var dbCategory = await _context.Categories.FindAsync(id);

            if (dbCategory == null)
            {
                throw new Exception("Unable to find the category");
            }

            _context.Categories.Remove(dbCategory);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                throw new Exception("Unable to find the category.");
            }

            return category;
        }
    }
}
