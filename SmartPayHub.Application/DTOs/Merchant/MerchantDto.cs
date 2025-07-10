using SmartPayHub.Application.DTOs.BankAccount;
using SmartPayHub.Application.DTOs.PaymentTerminal;
using SmartPayHub.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartPayHub.Application.DTOs.Merchant
{
    public class MerchantDto
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? DocumentNumber { get; set; }
        public List<UserDto>? Users { get; set; }
        public List<PaymentTerminalDto>? Terminals { get; set; }
        public BankAccountDto? BankAccount { get; set; } // Navigation property to BankAccount entity
    }
}
