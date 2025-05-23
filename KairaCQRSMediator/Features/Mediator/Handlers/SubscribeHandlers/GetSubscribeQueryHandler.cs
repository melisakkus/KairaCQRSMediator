using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.SubscribeQueries;
using KairaCQRSMediator.Features.Mediator.Results.SubscribeResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscribeHandlers
{
    public class GetSubscribeQueryHandler(IRepository<Subscribe> _repository, IMapper _mapper) : IRequestHandler<GetSubscribeQuery, List<GetSubscribeQueryResult>>
    {
        public async Task<List<GetSubscribeQueryResult>> Handle(GetSubscribeQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetSubscribeQueryResult>>(values);
        }
    }
}
