using AutoMapper;
using SmartPayHub.Domain.Entities;

using SmartPayHub.Application.DTOs.Merchant;
using SmartPayHub.Application.DTOs.User;
using SmartPayHub.Application.DTOs.PaymentTerminal;
using SmartPayHub.Application.DTOs.BankAccount;
using SmartPayHub.Application.DTOs.Pix;
using SmartPayHub.Application.DTOs.Settlement;
using SmartPayHub.Application.DTOs.Transaction;


namespace SmartPayHub.Application.Mappings
{
    public class DomainToDtoProfile : Profile
    {
        public DomainToDtoProfile()
        {
            CreateMap<MerchantEntity, MerchantDto>().ReverseMap();
            CreateMap<UserEntity, UserDto>().ReverseMap();
            CreateMap<PaymentTerminalEntity, PaymentTerminalDto>().ReverseMap();
            CreateMap<BankAccountEntity, BankAccountDto>().ReverseMap();
            CreateMap<PixQRCodeEntity, PixQRCodeDto>().ReverseMap();
            CreateMap<SettlementEntity, SettlementDto>().ReverseMap();
            CreateMap<TransactionEntity, TransactionDto>().ReverseMap();

        }
    }
}
