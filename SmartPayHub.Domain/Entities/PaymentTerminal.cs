using SmartPayHub.Domain.Enums;

namespace SmartPayHub.Domain.Entities
{
    public class PaymentTerminal
    {
        public int Id { get; set; }
        public string? serialNumber { get; set; }
        public string? model { get; set; }
        public TerminalStatus Status { get; set; }
        public DateTime? registrationDate { get; set; }
        public DateTime? lastUpdate { get; set; }
        public DateTime? lastConnection { get; set; }
        public string? OwnerId { get; set; }
    }
}
