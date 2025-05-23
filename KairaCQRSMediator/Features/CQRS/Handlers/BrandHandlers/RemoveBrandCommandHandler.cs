using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler(IRepository<Brand> _repository)
    {
        public async Task Handle(RemoveBrandCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }

    }
}
