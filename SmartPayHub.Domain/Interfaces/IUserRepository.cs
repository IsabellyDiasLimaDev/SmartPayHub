using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> GetAllUsersAsync();
        Task<UserEntity> GetUserByIdAsync(Guid userId);
        Task<UserEntity> GetUserByEmailAsync(string email);
        Task AddUserAsync(UserEntity user);
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(Guid userId);
        Task<bool> UserExistsAsync(Guid userId);
        Task<bool> EmailExistsAsync(string email);
    }
}
