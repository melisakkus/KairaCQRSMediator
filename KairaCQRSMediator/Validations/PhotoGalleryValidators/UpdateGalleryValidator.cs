using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;

namespace KairaCQRSMediator.Validations.PhotoGalleryValidators
{
    public class UpdateGalleryValidator : AbstractValidator<UpdateGalleryCommand>
    {
        public UpdateGalleryValidator() 
        {
            RuleFor(x => x.Url).NotEmpty().WithMessage("Link alanı boş bırakılamaz.");
        }
    }
}
