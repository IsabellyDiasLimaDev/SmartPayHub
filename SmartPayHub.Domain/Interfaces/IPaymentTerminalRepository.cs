using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IPaymentTerminalRepository
    {
        Task<IEnumerable<PaymentTerminal>> GetAllPaymentTerminalsAsync();
        Task<PaymentTerminal> GetPaymentTerminalByIdAsync(Guid terminalId);
        Task<IEnumerable<PaymentTerminal>> GetPaymentTerminalsByMerchantIdAsync(Guid merchantId);
        Task AddPaymentTerminalAsync(PaymentTerminal paymentTerminal);
        Task UpdatePaymentTerminalAsync(PaymentTerminal paymentTerminal);
        Task DeletePaymentTerminalAsync(Guid terminalId);
        Task<bool> PaymentTerminalExistsAsync(Guid terminalId);
        Task<bool> TerminalNameExistsAsync(string name, Guid merchantId);
    }
}
