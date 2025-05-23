using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;

namespace KairaCQRSMediator.Validations.SubscribeValidators
{
    public class UpdateSubscribeValidator : AbstractValidator<UpdateSubscribeCommand>
    {
        public UpdateSubscribeValidator() 
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
        }
    }
}
