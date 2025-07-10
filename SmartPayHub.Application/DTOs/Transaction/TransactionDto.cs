using SmartPayHub.Application.DTOs.BankAccount;
using SmartPayHub.Application.DTOs.PaymentTerminal;
using SmartPayHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SmartPayHub.Application.DTOs.Transaction
{
    public class TransactionDto
    {
        [Key]
        public Guid Id { get; private set; }
        public string? Description { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public TransactionType TransactionType { get; private set; } // Foreign key to TransactionType enum
        public TransactionStatus TransactionStatus { get; private set; } // Foreign key to TransactionStatus enum
        public string? AutorizationCode { get; private set; } // Code returned by the payment gateway

        public Guid BankAccountId { get; private set; } // Foreign key to BankAccount entity
        public BankAccountDto? BankAccount { get; private set; } // Assuming a BankAccount entity exists

        public Guid PaymentTerminalId { get; private set; } // Foreign key to PaymentTerminal entity
        public PaymentTerminalDto? PaymentTerminal { get; private set; } // Assuming a PaymentTerminal entity exists
    }
}
