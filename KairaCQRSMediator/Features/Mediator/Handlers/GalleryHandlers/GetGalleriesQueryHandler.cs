using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries;
using KairaCQRSMediator.Features.Mediator.Results.GalleryResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.GalleryHandlers
{
    public class GetGalleriesQueryHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<GetGalleriesQuery, List<GetGalleryQueryResult>>
    {
        public async Task<List<GetGalleryQueryResult>> Handle(GetGalleriesQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetGalleryQueryResult>>(values);
        }
    }
}
