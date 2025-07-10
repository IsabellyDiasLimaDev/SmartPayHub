using SmartPayHub.Domain.Enums;
using SmartPayHub.Application.DTOs.BankAccount;
using SmartPayHub.Application.DTOs.PaymentTerminal;
using System.ComponentModel.DataAnnotations;

namespace SmartPayHub.Application.DTOs.User
{
    public class UserDto
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public TypeUser Type { get; set; }
        public UserStatus Status { get; set; }
        public DateTime? registrationDate { get; set; }
        public DateTime? LastConnection { get; set; }
        public ICollection<PaymentTerminalDto>? PaymentTerminals { get; set; }
        public ICollection<BankAccountDto>? BankAccounts { get; set; } // Navigation property to BankAccount entity
    }
}
