using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities
{
    public class PaymentTerminalEntity
    {
        public int Id { get; set; }
        public string? serialNumber { get; set; }
        public string? model { get; set; }
        public string? Manufacturer { get; set; } // Manufacturer of the payment terminal
        public TerminalStatus Status { get; set; }
        public DateTime? registrationDate { get; set; }
        public DateTime? lastUpdate { get; set; }
        public DateTime? lastConnection { get; set; }
        public Guid? MerchantId { get; set; }
        public MerchantEntity? Merchant { get; set; } // Navigation property to Merchant entity
    }
}
