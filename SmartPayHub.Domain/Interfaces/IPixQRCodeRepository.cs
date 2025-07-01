using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IPixQrCodeRepository
    {
        Task<IEnumerable<PixQRCode>> GetAllPixQrCodesAsync();
        Task<PixQRCode> GetPixQrCodeByIdAsync(Guid pixQrCodeId);
        Task<IEnumerable<PixQRCode>> GetPixQrCodesByUserIdAsync(Guid userId);
        Task AddPixQrCodeAsync(PixQRCode pixQrCode);
        Task UpdatePixQrCodeAsync(PixQRCode pixQrCode);
        Task DeletePixQrCodeAsync(Guid pixQrCodeId);
        Task<bool> PixQrCodeExistsAsync(Guid pixQrCodeId);
    }
}
