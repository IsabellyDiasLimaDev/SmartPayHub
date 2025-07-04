using Microsoft.EntityFrameworkCore;
using SmartPayHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPayHub.Data.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet<MerchantEntity> Merchants { get; set; }
        DbSet<TransactionEntity> Transactions { get; set; }
        DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
        DbSet<BankAccountEntity> BankAccounts { get; set; }
        DbSet<PaymentTerminalEntity> PaymentTerminals { get; set; }
        DbSet<PixQRCodeEntity> PixQRCodes { get; set; }
        DbSet<SettlementEntity> Settlements { get; set; }
        DbSet<UserEntity> Users { get; set; }

        Task<int> SaveChangesAsync();
    }
}
