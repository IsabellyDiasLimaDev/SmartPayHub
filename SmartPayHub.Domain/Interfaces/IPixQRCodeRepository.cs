using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IPixQrCodeRepository
    {
        Task<IEnumerable<PixQRCodeEntity>> GetAllPixQrCodesAsync();
        Task<PixQRCodeEntity> GetPixQrCodeByIdAsync(Guid pixQrCodeId);
        Task<IEnumerable<PixQRCodeEntity>> GetPixQrCodesByUserIdAsync(Guid userId);
        Task AddPixQrCodeAsync(PixQRCodeEntity pixQrCode);
        Task UpdatePixQrCodeAsync(PixQRCodeEntity pixQrCode);
        Task DeletePixQrCodeAsync(Guid pixQrCodeId);
        Task<bool> PixQrCodeExistsAsync(Guid pixQrCodeId);
    }
}
