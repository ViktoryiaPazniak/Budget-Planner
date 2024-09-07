namespace BudgetPlanner.DAL.Entities
{
    public class UserEntity
    {
        public Guid UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public WalletEntity Wallet { get; set; }
    }
}
