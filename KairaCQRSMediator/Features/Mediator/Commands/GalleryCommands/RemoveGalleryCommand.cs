using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands
{
    public class RemoveGalleryCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveGalleryCommand(int id)
        {
            Id = id;
        }   
    }
}
