using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands
{
    public class CreateContactInfoCommand : IRequest
    {
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
