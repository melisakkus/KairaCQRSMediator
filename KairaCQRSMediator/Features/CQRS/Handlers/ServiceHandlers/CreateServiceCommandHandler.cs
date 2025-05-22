using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler
    {
        public IRepository<Service> _repository;
        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand command)
        {
            var value = new Service
            {
                Icon = command.Icon,
                Description = command.Description,
                Name = command.Name,
            };
            await _repository.CreateAsync(value);

        }
    }
}
