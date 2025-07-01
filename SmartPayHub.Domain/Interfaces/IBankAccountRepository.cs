using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<IEnumerable<BankAccount>> GetAllBankAccountsAsync();
        Task<BankAccount> GetBankAccountByIdAsync(Guid bankAccountId);
        Task<IEnumerable<BankAccount>> GetBankAccountsByUserIdAsync(Guid userId);
        Task AddBankAccountAsync(BankAccount bankAccount);
        Task UpdateBankAccountAsync(BankAccount bankAccount);
        Task DeleteBankAccountAsync(Guid bankAccountId);
    }
}
