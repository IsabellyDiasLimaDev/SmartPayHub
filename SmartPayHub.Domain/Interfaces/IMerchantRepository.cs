using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IMerchantRepository
    {
        Task<IEnumerable<Merchant>> GetAllMerchantsAsync();
        Task<Merchant> GetMerchantByIdAsync(Guid merchantId);
        Task<IEnumerable<Merchant>> GetMerchantsByUserIdAsync(Guid userId);
        Task AddMerchantAsync(Merchant merchant);
        Task UpdateMerchantAsync(Merchant merchant);
        Task DeleteMerchantAsync(Guid merchantId);
        Task<bool> MerchantExistsAsync(Guid merchantId);
        Task<bool> MerchantNameExistsAsync(string name);
    }
}
