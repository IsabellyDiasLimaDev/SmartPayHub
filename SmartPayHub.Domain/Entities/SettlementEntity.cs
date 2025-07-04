namespace SmartPayHub.Domain.Entities;

public class SettlementEntity
{
    public Guid Id { get; private set; }
    public Guid TransactionId { get; private set; }
    public decimal GrossAmount { get; private set; }
    public decimal Fee { get; private set; }
    public decimal NetAmount => GrossAmount - Fee;
    public DateTime ScheduledDate { get; private set; }

    protected SettlementEntity() {}

    public SettlementEntity(Guid transactionId, decimal grossAmount, decimal fee, DateTime scheduledDate)
    {
        Id = Guid.NewGuid();
        TransactionId = transactionId;
        GrossAmount = grossAmount;
        Fee = fee;
        ScheduledDate = scheduledDate;
    }
}
