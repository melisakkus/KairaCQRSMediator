using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands
{
    public class CreateGalleryCommand : IRequest
    {
        public string? Url { get; set; }
    }
}
