using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler(IRepository<Service> _repository)
    {
        public async Task Handle(UpdateServiceCommand command)
        {
            var value = new Service
            {
                ServiceId = command.ServiceId,
                Description = command.Description,
                Icon = command.Icon,
                Name = command.Name,
            };
            await _repository.UpdateAsync(value);
        }
    }
}
