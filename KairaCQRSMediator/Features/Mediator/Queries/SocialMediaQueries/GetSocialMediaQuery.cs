using KairaCQRSMediator.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediasQueryResult>>
    {
    }
}
