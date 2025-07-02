using SmartPayHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using SmartPayHub.Application.DTOs.Merchant;

namespace SmartPayHub.Application.DTOs.BankAccount
{
    public class BankAccountDto
    {
        [Key]
        public Guid Id { get; set; }
        public string? AccountNumber { get; set; }
        public string? AgencyNumber { get; set; }
        public string? BankName { get; set; }
        public AccountBankType AccountType { get; set; } // e.g., "Checking", "Savings"
        public Guid MerchantId { get; set; } // Foreign key to Merchant entity
        public MerchantDto? Merchant { get; set; } // Navigation property to Merchant entity
    }
}
