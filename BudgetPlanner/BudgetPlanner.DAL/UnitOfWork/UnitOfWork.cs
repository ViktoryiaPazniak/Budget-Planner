using BudgetPlanner.DAL.Contexts;
using BudgetPlanner.DAL.Repositories;

namespace BudgetPlanner.DAL.UnitOfWork
{
    public class UnitOfWork
    {
        private ApplicationDbContext _context;
        private CategoryRepository categoryRepository;
        private CurrencyRepository currencyRepository;
        private TransactionRepository transactionRepository;
        private UserRepository userRepository;
        private WalletRepository walletRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public CategoryRepository Categories
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(_context);
                return categoryRepository;
            }
        }

        public CurrencyRepository Currencies
        {
            get
            {
                if (currencyRepository == null)
                    currencyRepository = new CurrencyRepository(_context);
                return currencyRepository;
            }
        }

        public TransactionRepository Transactions
        {
            get
            {
                if (transactionRepository == null)
                    transactionRepository = new TransactionRepository(_context);
                return transactionRepository;
            }
        }

        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(_context);
                return userRepository;
            }
        }

        public WalletRepository Wallets
        {
            get
            {
                if (walletRepository == null)
                    walletRepository = new WalletRepository(_context);
                return walletRepository;
            }
        }
    }
}
