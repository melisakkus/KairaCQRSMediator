using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.ProductQueries
{
    public class GetProductByIdQuery(int id) : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; } =  id;
    }
}
