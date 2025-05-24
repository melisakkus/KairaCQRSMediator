using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands
{
    public class RemoveContactInfoCommand(int id): IRequest
    {
        public int Id = id;
    }
}
