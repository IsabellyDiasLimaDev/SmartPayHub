using SmartPayHub.Data.Base.Repositories;
using SmartPayHub.Data.Interfaces;
using SmartPayHub.Domain.Entities;
using SmartPayHub.Domain.Interfaces;

namespace SmartPayHub.Data.Repositories
{
    public class MerchantRepository : BaseRepository<MerchantEntity>, IMerchantRepository
    {
        public MerchantRepository(IAppDbContext context) : base(context) { }
    }
}
