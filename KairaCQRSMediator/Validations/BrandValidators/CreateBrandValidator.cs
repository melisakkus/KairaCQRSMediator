using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;

namespace KairaCQRSMediator.Validations.BrandValidators
{
    public class CreateBrandValidator : AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandValidator() 
        {
            RuleFor(x=>x.Icon).NotEmpty().WithMessage("Ikon bilgisi boş bırakılamaz.");
        }
    }
}
