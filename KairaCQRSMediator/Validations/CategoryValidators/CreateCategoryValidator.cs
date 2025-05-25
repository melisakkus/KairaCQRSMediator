using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands;

namespace KairaCQRSMediator.Validations.CategoryValidators
{
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryValidator() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
        }
    }
}
