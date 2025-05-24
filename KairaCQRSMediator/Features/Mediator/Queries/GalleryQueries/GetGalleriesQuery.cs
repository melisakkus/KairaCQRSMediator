using KairaCQRSMediator.Features.Mediator.Results.GalleryResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries
{
    public class GetGalleriesQuery : IRequest<List<GetGalleryQueryResult>>
    {
    }
}
