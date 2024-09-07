using AutoMapper;
using BudgetPlanner.BLL.Models;
using BudgetPlanner.DAL.Entities;

namespace BudgetPlanner.BLL.Maps
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Category, CategoryEntity>().ReverseMap();
            CreateMap<Currency, CurrencyEntity>().ReverseMap();
            CreateMap<Transaction, TransactionEntity>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<Wallet, WalletEntity>().ReverseMap();
        }
    }
}
