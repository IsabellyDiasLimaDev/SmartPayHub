using SmartPayHub.Application.DTOs.Merchant;
using SmartPayHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SmartPayHub.Application.DTOs.PaymentTerminal
{
    public class PaymentTerminalDto
    {
        [Key]
        public Guid Id { get; set; } // Unique identifier for the payment terminal
        public string? SerialNumber { get; set; } // Serial number of the payment terminal
        public string? Model { get; set; } // Model of the payment terminal
        public string? Manufacturer { get; set; } // Manufacturer of the payment terminal
        public TerminalStatus Status { get; set; }
        public DateTime? registrationDate { get; set; }
        public DateTime? lastUpdate { get; set; }
        public DateTime? lastConnection { get; set; }
        public Guid MerchantId { get; set; } // Foreign key to Merchant entity
        public MerchantDto? Merchant { get; set; } // Navigation property to Merchant entity    
    }
}
