using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync();
        Task<Transaction> GetTransactionByIdAsync(Guid transactionId);
        Task<IEnumerable<Transaction>> GetTransactionsByUserIdAsync(Guid userId);
        Task<IEnumerable<Transaction>> GetTransactionsByTerminalIdAsync(Guid terminalId);
        Task AddTransactionAsync(Transaction transaction);
        Task UpdateTransactionAsync(Transaction transaction);
        Task DeleteTransactionAsync(Guid transactionId);
    }
}
