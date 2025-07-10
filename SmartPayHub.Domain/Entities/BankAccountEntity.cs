using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities
{
    public class BankAccountEntity
    {
        public Guid Id { get; private set; }
        public string? AccountNumber { get; private set; }
        public string? AgencyNumber { get; private set; }
        public string? BankName { get; private set; }
        public AccountBankType AccountType { get; private set; } // Enum for account type
        
        public Guid MerchantId { get; private set; } // Foreign key to Merchant entity
        public MerchantEntity Merchant { get; private set; } // Navigation property to Merchant entity

        public BankAccountEntity(string accountNumber, string agencyNumber, string bankName, AccountBankType accountType, Guid merchantId)
        {
            Id = Guid.NewGuid();
            AccountNumber = accountNumber;
            AgencyNumber = agencyNumber;
            BankName = bankName;
            AccountType = accountType;
            this.MerchantId = merchantId; // Set the foreign key
        }
    }
}
