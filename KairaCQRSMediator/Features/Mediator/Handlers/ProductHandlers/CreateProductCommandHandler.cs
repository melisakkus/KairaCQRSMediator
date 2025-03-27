using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<CreateProductCommand>
    {
        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Product>(request);
            await _repository.CreateAsync(value);
        }
    }
}
