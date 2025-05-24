using KairaCQRSMediator.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery(int id) : IRequest<GetSocialMediaByIdQueryResult>
    {
        public int Id = id;
    }
}
