namespace BudgetPlanner.DAL.Entities
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public string? TransactionName { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncreaseInBalance { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
