using FluentValidation;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;

namespace KairaCQRSMediator.Validations.SocialMediaValidators
{
    public class UpdateSocialValidator : AbstractValidator<UpdateSocialMediaCommand>
    {
        public UpdateSocialValidator()
        {
            RuleFor(x => x.Url).NotEmpty().WithMessage("Sosyal Medya linki boş bırakılamaz.");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Sosyal Medya ikonu boş bırakılamaz.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Sosyal Medya ismi boş bırakılamaz.");
        }
    }
}
