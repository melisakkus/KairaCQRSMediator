using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.GalleryHandlers
{
    public class UpdateGalleryCommandHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<UpdateGalleryCommand>
    {
        public async Task Handle(UpdateGalleryCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<PhotoGallery>(request);
            await _repository.UpdateAsync(value);
        }
    }
}
