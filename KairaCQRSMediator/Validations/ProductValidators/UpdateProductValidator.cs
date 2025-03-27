using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;

namespace KairaCQRSMediator.Validations.ProductValidators
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün ismi boş geçilemez.").
                MinimumLength(3).WithMessage("Ürün adı en az iki karakter olmalıdır.").
                MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün görseli boş bırakılamaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş bırakılamaz.").
                InclusiveBetween(10, 10000).WithMessage("Ürün fiyatı 10 - 10.000 Tl arasında olmalıdır.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Ürün kategorisi boş bırakılamaz.");
        }
    }
}
