using SmartPayHub.Application.DTOs.Merchant;
using SmartPayHub.Application.DTOs.User;

namespace SmartPayHub.Application.UseCases.Merchant.Interfaces
{
    public interface IMerchantUseCase
    {
        public Task CreateMerchantAsync(MerchantDto merchant);
        //public Task<MerchantDto?> GetMerchantByIdAsync(Guid id);
        //public Task<MerchantDto?> GetMerchantByDocumentNumberAsync(string documentNumber);
        //public Task UpdateMerchantAsync(MerchantDto merchant);
        //public Task DeleteMerchantAsync(Guid id);
        //public Task AddUserToMerchantAsync(Guid merchantId, UserDto user);
    }
}
