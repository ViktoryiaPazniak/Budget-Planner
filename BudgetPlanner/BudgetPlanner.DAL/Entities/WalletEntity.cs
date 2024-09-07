namespace BudgetPlanner.DAL.Entities
{
    public class WalletEntity
    {
        public Guid WalletId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Amount { get; set; }
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
