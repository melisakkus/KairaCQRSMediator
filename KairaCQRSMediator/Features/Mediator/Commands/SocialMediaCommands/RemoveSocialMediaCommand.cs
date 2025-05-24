using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands
{
    public class RemoveSocialMediaCommand(int id) : IRequest
    {
        public int Id = id;
    }
}
