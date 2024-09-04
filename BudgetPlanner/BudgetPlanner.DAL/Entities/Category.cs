namespace BudgetPlanner.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
