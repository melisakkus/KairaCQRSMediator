using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler(IRepository<Product> _repository,IMapper _mapper) : IRequestHandler<UpdateProductCommand>
    {
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _repository.UpdateAsync(product);
        }
    }
}
