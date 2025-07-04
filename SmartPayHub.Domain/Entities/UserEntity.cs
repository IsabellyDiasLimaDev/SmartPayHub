using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public TypeUser Type { get; set; }
        public UserStatus Status { get; set; }
        public DateTime? registrationDate { get; set; }
        public DateTime? LastConnection { get; set; }
        public ICollection<PaymentTerminalEntity>? PaymentTerminals { get; private set; }
        public ICollection<BankAccountEntity>? BankAccounts { get; private set; }


        public UserEntity(string name, string email, string phoneNumber, TypeUser type)
        {
            Id = Guid.NewGuid().GetHashCode(); // Example of generating a unique Id, replace with your logic
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Type = type;
            Status = UserStatus.Ativo; // Default status
            registrationDate = DateTime.UtcNow; // Set registration date to current time
            PaymentTerminals = new HashSet<PaymentTerminalEntity>();
            BankAccounts = new HashSet<BankAccountEntity>();
        }

        public void RegistrarConexao()
        {
            LastConnection = DateTime.UtcNow;
        }

    }
}
