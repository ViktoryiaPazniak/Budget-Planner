namespace BudgetPlanner.DAL.Entities
{
    public class CurrencyEntity
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public ICollection<WalletEntity> Wallets { get; set; }
    }
}
