using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities
{
    public class TransactionEntity
    {
        public Guid Id { get; private set; }
        public string? Description { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public TransactionType TransactionType { get; private set; } // Foreign key to TransactionType enum
        public TransactionStatus TransactionStatus { get; private set; } // Foreign key to TransactionStatus enum
        public string AutorizationCode { get; private set; } // Code returned by the payment gateway

        public Guid PaymentTerminalId { get; private set; } // Foreign key to PaymentTerminal entity
        public PaymentTerminalEntity PaymentTerminal { get; private set; } // Assuming a PaymentTerminal entity exists

        public Guid PaymentMethodId { get; private set; } // Foreign key to PaymentMethod entity
        public PaymentMethodEntity? PaymentMethod { get; private set; } // Navigation property to PaymentMethod entity

        public PixQRCodeEntity? PixQRCode { get; set; }

        public Guid SettlementId { get; set; } // Foreign key to Settlement entity
        public SettlementEntity? Settlement { get; set; } // Navigation property to Settlement entity

        public TransactionEntity(decimal amount, TransactionType transactionType, Guid paymentTerminalId, Guid paymentMethodId, string autorizationCode, string? description = null)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            TransactionType = transactionType;
            PaymentMethodId = paymentMethodId;
            PaymentTerminalId = paymentTerminalId;
            AutorizationCode = autorizationCode;
            Description = description;
            TransactionDate = DateTime.UtcNow; // Default to current UTC time
            TransactionStatus = TransactionStatus.Pendente; // Default status to Pending
        }
    }
}
