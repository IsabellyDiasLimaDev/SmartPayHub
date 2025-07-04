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


        public int BankAccountId { get; private set; } // Foreign key to BankAccount entity
        public BankAccountEntity BankAccount { get; private set; } // Assuming a BankAccount entity exists

        public int PaymentTerminalId { get; private set; } // Foreign key to PaymentTerminal entity
        public PaymentTerminalEntity PaymentTerminal { get; private set; } // Assuming a PaymentTerminal entity exists

        public TransactionEntity(decimal amount, TransactionType transactionType, int paymentTerminalId, int bankAccountId, string autorizationCode, string? description = null)
        {
            Amount = amount;
            TransactionType = transactionType;
            PaymentTerminalId = paymentTerminalId;
            BankAccountId = bankAccountId;
            AutorizationCode = autorizationCode;
            Description = description;
            TransactionDate = DateTime.UtcNow; // Default to current UTC time
            TransactionStatus = TransactionStatus.Pendente; // Default status to Pending

        }
    }
}
