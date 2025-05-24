using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.GalleryHandlers
{
    public class CreateGalleryCommandHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<CreateGalleryCommand>
    {
        public async Task Handle(CreateGalleryCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<PhotoGallery>(request);
            await _repository.CreateAsync(value);
        }
    }
}
