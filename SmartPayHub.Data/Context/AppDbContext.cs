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
        public PixQRCodeEntity? PixQRCode { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionEntity>()
                .ToTable("Transaction")
                .HasOne(t => t.PaymentTerminal)
                .WithMany(pt => pt.Transactions)
                .HasForeignKey(t => t.PaymentTerminalId);

            modelBuilder.Entity<TransactionEntity>()
                .HasOne(t => t.PaymentMethod)
                .WithMany(pm => pm.Transactions)
                .HasForeignKey(t => t.PaymentMethodId);

            modelBuilder.Entity<TransactionEntity>()
                .HasOne(t => t.PixQRCode)
                .WithOne(p => p.Transaction)
                .HasForeignKey<PixQRCodeEntity>(p => p.TransactionId);

            modelBuilder.Entity<MerchantEntity>()
                .ToTable("Merchant")
                .HasOne(m => m.BankAccount)
                .WithOne(b => b.Merchant)
                .HasPrincipalKey<MerchantEntity>(m => m.Id)
                .HasForeignKey<BankAccountEntity>(b => b.MerchantId);

            modelBuilder.Entity<PaymentMethodEntity>()
                .ToTable("PaymentMethod");

            modelBuilder.Entity<BankAccountEntity>()
                .ToTable("BankAccount")
                .HasOne(ba => ba.Merchant)
                .WithOne(m => m.BankAccount)
                .HasForeignKey<MerchantEntity>(m => m.BankAccountId);

            modelBuilder.Entity<PaymentTerminalEntity>()
                .ToTable("PaymentTerminal")
                .HasOne(pt => pt.Merchant)
                .WithMany(m => m.Terminals)
                .HasForeignKey(pt => pt.MerchantId);

            modelBuilder.Entity<PixQRCodeEntity>()
                .ToTable("PixQRCode")
                .HasOne(p => p.Transaction)
                .WithOne(t => t.PixQRCode)
                .HasForeignKey<PixQRCodeEntity>(p => p.TransactionId);

            modelBuilder.Entity<SettlementEntity>()
                .ToTable("Settlement")
                .HasOne(s => s.Transaction)
                .WithOne(u => u.Settlement)
                .HasForeignKey<SettlementEntity>(s => s.TransactionId);

            modelBuilder.Entity<UserEntity>()
                .ToTable("User")
                .HasOne(u => u.Merchant)
                .WithMany(m => m.Users)
                .HasForeignKey(u => u.MerchantId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
