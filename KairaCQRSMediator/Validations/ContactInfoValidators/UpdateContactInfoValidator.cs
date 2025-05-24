using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;

namespace KairaCQRSMediator.Validations.ContactInfoValidators
{
    public class UpdateContactInfoValidator : AbstractValidator<UpdateContactInfoCommand>
    {
        public UpdateContactInfoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş bırakılamaz.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon numarası boş bırakılamaz.");
        }
    }
}
