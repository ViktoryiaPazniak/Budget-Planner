namespace BudgetPlanner.DAL.Entities
{
    public class TransactionEntity
    {
        public Guid TransactionId { get; set; }
        public string? TransactionName { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncreaseInBalance { get; set; }
        public Guid WalletId { get; set; }
        public WalletEntity Wallet { get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
