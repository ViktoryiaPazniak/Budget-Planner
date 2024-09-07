namespace BudgetPlanner.DAL.Entities
{
    public class CategoryEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
