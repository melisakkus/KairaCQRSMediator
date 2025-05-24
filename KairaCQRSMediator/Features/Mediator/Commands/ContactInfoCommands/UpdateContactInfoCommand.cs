using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands
{
    public class UpdateContactInfoCommand : IRequest
    {
        public int ContactInfoId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
