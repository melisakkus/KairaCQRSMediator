using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries;
using KairaCQRSMediator.Features.Mediator.Results.GalleryResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.GalleryHandlers
{
    public class GetGalleryByIdQueryHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<GetGalleryByIdQuery, GetGalleryByIdQueryResult>
    {
        public async Task<GetGalleryByIdQueryResult> Handle(GetGalleryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetGalleryByIdQueryResult>(value);
        }
    }
}
