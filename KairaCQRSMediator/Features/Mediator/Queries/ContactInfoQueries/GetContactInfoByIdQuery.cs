using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries
{
    public class GetContactInfoByIdQuery(int id) : IRequest<GetContactInfoByIdQueryResult>
    {
        public int Id = id;
    }
}
