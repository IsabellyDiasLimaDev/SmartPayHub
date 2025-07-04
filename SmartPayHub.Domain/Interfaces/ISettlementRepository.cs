using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface ISettlementRepository
    {
        Task<IEnumerable<SettlementEntity>> GetAllSettlementsAsync();
        Task<SettlementEntity> GetSettlementByIdAsync(Guid settlementId);
        Task<IEnumerable<SettlementEntity>> GetSettlementsByMerchantIdAsync(Guid merchantId);
        Task AddSettlementAsync(SettlementEntity settlement);
        Task UpdateSettlementAsync(SettlementEntity settlement);
        Task DeleteSettlementAsync(Guid settlementId);
        Task<bool> SettlementExistsAsync(Guid settlementId);
        Task<bool> SettlementExistsForMerchantAsync(Guid settlementId, Guid merchantId);
        Task<IEnumerable<SettlementEntity>> GetSettlementsByDateRangeAsync(Guid merchantId, DateTime startDate, DateTime endDate);
        Task<decimal> GetTotalSettledAmountAsync(Guid merchantId, DateTime startDate, DateTime endDate);
        Task<decimal> GetTotalSettledAmountAsync(Guid merchantId, DateTime startDate, DateTime endDate, string currencyCode);
        Task<IEnumerable<SettlementEntity>> GetSettlementsByStatusAsync(Guid merchantId, string status);
        Task<IEnumerable<SettlementEntity>> GetSettlementsByStatusAndDateRangeAsync(Guid merchantId, string status, DateTime startDate, DateTime endDate);

    }
}
