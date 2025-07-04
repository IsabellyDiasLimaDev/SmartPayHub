namespace SmartPayHub.Domain.Entities;

public class PixQRCodeEntity
{
    public Guid Id { get; private set; }
    public Guid TransactionId { get; private set; }
    public string Payload { get; private set; }
    public string Url { get; private set; }
    public DateTime Expiration { get; private set; }

    protected PixQRCodeEntity() {}

    public PixQRCodeEntity(Guid transactionId, string payload, string url, DateTime expiration)
    {
        Id = Guid.NewGuid();
        TransactionId = transactionId;
        Payload = payload;
        Url = url;
        Expiration = expiration;
    }

    public bool IsExpired() => DateTime.UtcNow > Expiration;
}
