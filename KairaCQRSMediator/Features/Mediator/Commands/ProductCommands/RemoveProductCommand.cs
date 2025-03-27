using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ProductCommands
{
    public class RemoveProductCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
