using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    internal interface IPaymentMethodRepository
    {
        Task<IEnumerable<PaymentMethodEntity>> GetAllPaymentMethodsAsync();
        Task<PaymentMethodEntity> GetPaymentMethodByIdAsync(Guid paymentMethodId);
        Task<IEnumerable<PaymentMethodEntity>> GetPaymentMethodsByUserIdAsync(Guid userId);
        Task AddPaymentMethodAsync(PaymentMethodEntity paymentMethod);
        Task UpdatePaymentMethodAsync(PaymentMethodEntity paymentMethod);
        Task DeletePaymentMethodAsync(Guid paymentMethodId);
        Task<bool> PaymentMethodExistsAsync(Guid paymentMethodId);
    }
}
