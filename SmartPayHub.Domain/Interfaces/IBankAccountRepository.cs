using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<IEnumerable<BankAccountEntity>> GetAllBankAccountsAsync();
        Task<BankAccountEntity> GetBankAccountByIdAsync(Guid bankAccountId);
        Task<IEnumerable<BankAccountEntity>> GetBankAccountsByUserIdAsync(Guid userId);
        Task AddBankAccountAsync(BankAccountEntity bankAccount);
        Task UpdateBankAccountAsync(BankAccountEntity bankAccount);
        Task DeleteBankAccountAsync(Guid bankAccountId);
    }
}
