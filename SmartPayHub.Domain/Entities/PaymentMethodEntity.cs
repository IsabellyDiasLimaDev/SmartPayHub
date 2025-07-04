using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities;

public class PaymentMethodEntity
{
    public Guid Id { get; private set; }
    public TransactionType Type { get; private set; } // e.g., Credit, Debit, Pix
    public string Provider { get; private set; } // e.g., Visa, Master, Banco do Brasil
    public string LastDigits { get; private set; } // if applicable

    protected PaymentMethodEntity() {}

    public PaymentMethodEntity(TransactionType type, string provider, string lastDigits)
    {
        Id = Guid.NewGuid();
        Type = type;
        Provider = provider;
        LastDigits = lastDigits;
    }
}
