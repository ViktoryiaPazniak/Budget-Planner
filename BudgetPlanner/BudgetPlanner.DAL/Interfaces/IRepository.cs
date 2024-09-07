namespace BudgetPlanner.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task Create(T _object);
        public Task Update(T _object);
        public Task Delete(int id);
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
    }
}
