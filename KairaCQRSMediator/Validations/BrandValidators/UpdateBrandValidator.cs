using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;

namespace KairaCQRSMediator.Validations.BrandValidators
{
    public class UpdateBrandValidator : AbstractValidator<UpdateBrandCommand>
    {
        public UpdateBrandValidator() 
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon bilgisi boş bırakılamaz.");
        }
    }
}
