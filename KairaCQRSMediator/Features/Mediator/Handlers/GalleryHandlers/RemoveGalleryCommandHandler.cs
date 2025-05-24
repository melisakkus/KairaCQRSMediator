using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.GalleryHandlers
{
    public class RemoveGalleryCommandHandler(IRepository<PhotoGallery> _repository) : IRequestHandler<RemoveGalleryCommand>
    {
        public async Task Handle(RemoveGalleryCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
