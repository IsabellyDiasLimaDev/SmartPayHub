using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface ISettlementRepository
    {
        Task<IEnumerable<Settlement>> GetAllSettlementsAsync();
        Task<Settlement> GetSettlementByIdAsync(Guid settlementId);
        Task<IEnumerable<Settlement>> GetSettlementsByMerchantIdAsync(Guid merchantId);
        Task AddSettlementAsync(Settlement settlement);
        Task UpdateSettlementAsync(Settlement settlement);
        Task DeleteSettlementAsync(Guid settlementId);
        Task<bool> SettlementExistsAsync(Guid settlementId);
        Task<bool> SettlementExistsForMerchantAsync(Guid settlementId, Guid merchantId);
        Task<IEnumerable<Settlement>> GetSettlementsByDateRangeAsync(Guid merchantId, DateTime startDate, DateTime endDate);
        Task<decimal> GetTotalSettledAmountAsync(Guid merchantId, DateTime startDate, DateTime endDate);
        Task<decimal> GetTotalSettledAmountAsync(Guid merchantId, DateTime startDate, DateTime endDate, string currencyCode);
        Task<IEnumerable<Settlement>> GetSettlementsByStatusAsync(Guid merchantId, string status);
        Task<IEnumerable<Settlement>> GetSettlementsByStatusAndDateRangeAsync(Guid merchantId, string status, DateTime startDate, DateTime endDate);

    }
}
