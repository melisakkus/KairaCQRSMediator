using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler(IRepository<Service> _repository)
    {
        public async Task Handle(RemoveServiceCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}
