namespace BudgetPlanner.DAL.Entities
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; } = string.Empty;
        public ICollection<Wallet> Wallets { get; set; }
    }
}
