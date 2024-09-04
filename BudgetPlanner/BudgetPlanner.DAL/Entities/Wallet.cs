namespace BudgetPlanner.DAL.Entities
{
    public class Wallet
    {
        public Guid WalletId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Amount { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
