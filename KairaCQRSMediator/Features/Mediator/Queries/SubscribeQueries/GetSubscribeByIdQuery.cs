using KairaCQRSMediator.Features.Mediator.Results.SubscribeResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.SubscribeQueries
{
    public class GetSubscribeByIdQuery : IRequest<GetSubscribeByIdQueryResult>
    {
        public int Id { get; set; }
        public GetSubscribeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
