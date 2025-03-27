using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler(IRepository<Product> _repository) : IRequestHandler<RemoveProductCommand>
    {
        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
