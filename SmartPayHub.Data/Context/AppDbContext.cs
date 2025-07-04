using Microsoft.EntityFrameworkCore;
using SmartPayHub.Data.Interfaces;
using SmartPayHub.Domain.Entities;

namespace SmartPayHub.Data.Context
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<TEntity> Set<TEntity>() where TEntity : class => base.Set<TEntity>();
        public DbSet<MerchantEntity> Merchants { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
        public DbSet<BankAccountEntity> BankAccounts { get; set; }
        public DbSet<PaymentTerminalEntity> PaymentTerminals { get; set; }
        public DbSet<PixQRCodeEntity> PixQRCodes { get; set; }
        public DbSet<SettlementEntity> Settlements { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        //TODO : Configure OnModelCreating method to set up relationships and constraints
    }
}
