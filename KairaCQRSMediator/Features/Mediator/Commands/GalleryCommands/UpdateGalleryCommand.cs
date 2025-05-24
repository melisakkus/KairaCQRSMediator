using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands
{
    public class UpdateGalleryCommand : IRequest
    {
        public int PhotoGalleryId { get; set; }
        public string? Url { get; set; }
    }
}
