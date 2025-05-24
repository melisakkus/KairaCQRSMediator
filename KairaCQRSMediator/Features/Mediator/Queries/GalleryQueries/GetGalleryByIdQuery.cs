using KairaCQRSMediator.Features.Mediator.Results.GalleryResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries
{
    public class GetGalleryByIdQuery : IRequest<GetGalleryByIdQueryResult>
    {
        public int Id;
        public GetGalleryByIdQuery(int id)
        {
            Id = id;
        }

    }
}
