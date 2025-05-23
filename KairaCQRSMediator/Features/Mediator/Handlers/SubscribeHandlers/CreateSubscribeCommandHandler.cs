using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscribeHandlers
{
    public class CreateSubscribeCommandHandler(IRepository<Subscribe> _repository, IMapper _mapper) : IRequestHandler<CreateSubscribeCommand>
    {
        public async Task Handle(CreateSubscribeCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Subscribe>(request);
            await _repository.CreateAsync(value);
        }
    }
}
