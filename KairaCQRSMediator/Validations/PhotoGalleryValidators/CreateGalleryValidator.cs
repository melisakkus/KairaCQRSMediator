using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;

namespace KairaCQRSMediator.Validations.PhotoGalleryValidators
{
    public class CreateGalleryValidator : AbstractValidator<CreateGalleryCommand>
    {
        public CreateGalleryValidator() 
        {
            RuleFor(x => x.Url).NotEmpty().WithMessage("Link alanı boş bırakılamaz.");
        }
    }
}
