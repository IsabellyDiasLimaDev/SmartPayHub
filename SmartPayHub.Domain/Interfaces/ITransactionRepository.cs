using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<TransactionEntity>> GetAllTransactionsAsync();
        Task<TransactionEntity> GetTransactionByIdAsync(Guid transactionId);
        Task<IEnumerable<TransactionEntity>> GetTransactionsByUserIdAsync(Guid userId);
        Task<IEnumerable<TransactionEntity>> GetTransactionsByTerminalIdAsync(Guid terminalId);
        Task AddTransactionAsync(TransactionEntity transaction);
        Task UpdateTransactionAsync(TransactionEntity transaction);
        Task DeleteTransactionAsync(Guid transactionId);
    }
}
