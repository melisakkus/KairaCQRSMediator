using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.SubscribeQueries;
using KairaCQRSMediator.Features.Mediator.Results.SubscribeResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscribeHandlers
{
    public class GetSubscribeByIdQueryHandler(IRepository<Subscribe> _repository, IMapper _mapper) :
        IRequestHandler<GetSubscribeByIdQuery, GetSubscribeByIdQueryResult>
    {
        public async Task<GetSubscribeByIdQueryResult> Handle(GetSubscribeByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetSubscribeByIdQueryResult>(value);
        }
    }
}
