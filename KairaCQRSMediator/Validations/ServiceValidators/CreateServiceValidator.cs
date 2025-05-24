using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;

namespace KairaCQRSMediator.Validations.ServiceValidators
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceCommand>
    {
        public CreateServiceValidator() 
        {
            RuleFor(x=>x.Icon).NotEmpty().WithMessage("Ikon bilgisi boş bırakılmaz.");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim bilgisi boş bırakılmaz.");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama bilgisi boş bırakılmaz.");
        }
    }
}
