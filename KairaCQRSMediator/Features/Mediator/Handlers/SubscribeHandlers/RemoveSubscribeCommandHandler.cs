using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscribeHandlers
{
    public class RemoveSubscribeCommandHandler(IRepository<Subscribe> _repository) : IRequestHandler<RemoveSubscribeCommand>
    {
        public async Task Handle(RemoveSubscribeCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
