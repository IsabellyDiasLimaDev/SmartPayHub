using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    internal interface IPaymentMethodRepository
    {
        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodsAsync();
        Task<PaymentMethod> GetPaymentMethodByIdAsync(Guid paymentMethodId);
        Task<IEnumerable<PaymentMethod>> GetPaymentMethodsByUserIdAsync(Guid userId);
        Task AddPaymentMethodAsync(PaymentMethod paymentMethod);
        Task UpdatePaymentMethodAsync(PaymentMethod paymentMethod);
        Task DeletePaymentMethodAsync(Guid paymentMethodId);
        Task<bool> PaymentMethodExistsAsync(Guid paymentMethodId);
    }
}
