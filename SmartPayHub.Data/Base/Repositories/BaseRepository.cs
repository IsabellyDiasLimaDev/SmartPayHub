using SmartPayHub.Data.Interfaces;
using SmartPayHub.Domain.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SmartPayHub.Data.Base.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
            where TEntity : class
    {
        private readonly IAppDbContext _context;

        public BaseRepository(IAppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<TEntity?> UpdateAsync(TEntity entity)
        {
            // Fix for IDE0270: Simplify null conditional selection
            var entityId = entity.GetType().GetProperty("Id")?.GetValue(entity);
            if (entityId == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity Id cannot be null.");
            }

            // Fix for CS1061: Use DbContext instead of IAppDbContext for accessing Entry method
            if (_context is DbContext dbContext)
            {
                var existingEntity = await dbContext.Set<TEntity>().FindAsync(entityId);
                if (existingEntity == null)
                {
                    throw new InvalidOperationException("Entity not found for update.");
                }
                dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
                await dbContext.SaveChangesAsync();
                return existingEntity;
            }
            else
            {
                throw new InvalidOperationException("The provided context does not support entity tracking.");
            }
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            // Fix for CS8073: Use GetAwaiter().GetResult() to access ValueTask result safely
            var entityTask = _context.Set<TEntity>().FindAsync(id);
            if (!entityTask.IsCompleted)
            {
                await entityTask;
            }
            var entity = entityTask.GetAwaiter().GetResult();

            // Fix for CS8604: Ensure entity is not null before calling Remove
            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found for deletion.");
            }

            _context.Set<TEntity>().Remove(entity);

            // Fix for CS4032: Mark method as async and await SaveChangesAsync
            await _context.SaveChangesAsync();
        }

        public virtual async Task<bool> ExistsAsync(Guid id)
        {
            // Check if the entity exists in the database using the provided ID
            var entity = await _context.Set<TEntity>().FindAsync(id);

            // Return true if the entity is not null, otherwise false
            return entity != null;
        }
    }
}
