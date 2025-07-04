using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IMerchantRepository
    {
        Task<IEnumerable<MerchantEntity>> GetAllMerchantsAsync();
        Task<MerchantEntity> GetMerchantByIdAsync(Guid merchantId);
        Task<IEnumerable<MerchantEntity>> GetMerchantsByUserIdAsync(Guid userId);
        Task AddMerchantAsync(MerchantEntity merchant);
        Task UpdateMerchantAsync(MerchantEntity merchant);
        Task DeleteMerchantAsync(Guid merchantId);
        Task<bool> MerchantExistsAsync(Guid merchantId);
        Task<bool> MerchantNameExistsAsync(string name);
    }
}
