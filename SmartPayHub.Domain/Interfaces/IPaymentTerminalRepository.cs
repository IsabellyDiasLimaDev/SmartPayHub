using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IPaymentTerminalRepository
    {
        Task<IEnumerable<PaymentTerminalEntity>> GetAllPaymentTerminalsAsync();
        Task<PaymentTerminalEntity> GetPaymentTerminalByIdAsync(Guid terminalId);
        Task<IEnumerable<PaymentTerminalEntity>> GetPaymentTerminalsByMerchantIdAsync(Guid merchantId);
        Task AddPaymentTerminalAsync(PaymentTerminalEntity paymentTerminal);
        Task UpdatePaymentTerminalAsync(PaymentTerminalEntity paymentTerminal);
        Task DeletePaymentTerminalAsync(Guid terminalId);
        Task<bool> PaymentTerminalExistsAsync(Guid terminalId);
        Task<bool> TerminalNameExistsAsync(string name, Guid merchantId);
    }
}
