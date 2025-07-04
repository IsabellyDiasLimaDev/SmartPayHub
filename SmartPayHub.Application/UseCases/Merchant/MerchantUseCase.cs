using SmartPayHub.Domain.Interfaces;
using SmartPayHub.Application.DTOs.Merchant;
using SmartPayHub.Domain.Entities;
using AutoMapper;
using SmartPayHub.Application.UseCases.Merchant.Interfaces;

namespace SmartPayHub.Application.UseCases.Merchant
{
    public class MerchantUseCase : IMerchantUseCase
    {
        private readonly IMerchantRepository _merchantRepository;
        private readonly IMapper _mapper;
        public MerchantUseCase(IMerchantRepository merchantRepository, IMapper mapper)
        {
            _merchantRepository = merchantRepository;
            _mapper = mapper;
        }

        public async Task CreateMerchantAsync(MerchantDto merchant)
        {
            var entity = _mapper.Map<MerchantEntity>(merchant);
            await _merchantRepository.AddAsync(entity);
        }
    }
}
