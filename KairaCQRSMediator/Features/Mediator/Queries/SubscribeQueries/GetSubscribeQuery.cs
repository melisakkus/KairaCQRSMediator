using KairaCQRSMediator.Features.Mediator.Results.SubscribeResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.SubscribeQueries
{
    public class GetSubscribeQuery : IRequest<List<GetSubscribeQueryResult>>
    {
    }
}
