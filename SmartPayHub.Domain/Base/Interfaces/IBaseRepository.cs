using Microsoft.EntityFrameworkCore;

namespace SmartPayHub.Domain.Base.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        Task<TEntity?> UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id);
    }
}
