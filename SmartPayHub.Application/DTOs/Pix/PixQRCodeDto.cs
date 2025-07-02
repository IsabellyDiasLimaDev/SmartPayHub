namespace SmartPayHub.Application.DTOs.Pix
{
    public class PixQRCodeDto
    {
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public string Payload { get; set; }
        public string Url { get; set; }
        public DateTime Expiration { get; set; }
        public bool IsExpired() => DateTime.UtcNow > Expiration;
    }
}