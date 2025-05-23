using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands
{
    public class RemoveSubscribeCommand(int id) : IRequest
    {
        public int Id = id;
    }
}
