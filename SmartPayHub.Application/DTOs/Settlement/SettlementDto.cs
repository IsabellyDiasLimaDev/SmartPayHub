namespace SmartPayHub.Application.DTOs.Settlement
{
    public class SettlementDto
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal Fee { get; set; }
        public decimal NetAmount => GrossAmount - Fee;
        public DateTime ScheduledDate { get; set; }
    }
}
