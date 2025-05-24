using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;

namespace KairaCQRSMediator.Validations.TestimonialValidators
{
    public class CreateTestimonialValidator : AbstractValidator<CreateTestimonialCommand>
    {
        public CreateTestimonialValidator()
        {
            RuleFor(x => x.ByName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Yorum alanı boş bırakılamaz.");
        }
    }
}
