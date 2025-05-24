using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;

namespace KairaCQRSMediator.Validations.ContactInfoValidators
{
    public class CreateContactInfoValidator : AbstractValidator<CreateContactInfoCommand>
    {
        public CreateContactInfoValidator() 
        {
            RuleFor(x=>x.Email).NotEmpty().WithMessage("Email boş bırakılamaz.");
            RuleFor(x=>x.Phone).NotEmpty().WithMessage("Telefon numarası boş bırakılamaz.");
        }
    }
}
