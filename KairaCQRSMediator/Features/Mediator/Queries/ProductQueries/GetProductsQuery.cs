using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.ProductQueries
{
    public class GetProductsQuery : IRequest<List<GetProductsQueryResult>>
    {
    }
}
