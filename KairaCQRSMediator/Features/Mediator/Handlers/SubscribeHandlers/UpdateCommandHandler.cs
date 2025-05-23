using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscribeHandlers
{
    public class UpdateCommandHandler(IRepository<Subscribe> _repository, IMapper _mapper) : IRequestHandler<UpdateSubscribeCommand>
    {
        public async Task Handle(UpdateSubscribeCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Subscribe>(request);
            await _repository.UpdateAsync(value);
        }
    }
}
