using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler(IRepository<Brand> _repository, IMapper _mapper)
    {
        public async Task Handle(UpdateBrandCommand command)
        {
            var value = _mapper.Map<Brand>(command);
            await _repository.UpdateAsync(value);
        }
    }
}
