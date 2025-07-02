using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities
{
    public class BankAccount
    {
        public int Id { get; private set; }
        public string? AccountNumber { get; private set; }
        public string? AgencyNumber { get; private set; }
        public string? BankName { get; private set; }
        public AccountBankType AccountType { get; private set; } // Enum for account type
        
        public int holderId { get; private set; } // Foreign key to User entity
        public User Holder { get; private set; } // Navigation property to User entity

        public BankAccount(string accountNumber, string agencyNumber, string bankName, AccountBankType accountType, int holderId)
        {
            AccountNumber = accountNumber;
            AgencyNumber = agencyNumber;
            BankName = bankName;
            AccountType = accountType;
            this.holderId = holderId; // Set the foreign key
        }
    }
}
