using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{

    [ViewComponent(Name = "NewCollectionLastProductsViewComponent")]
    public class NewCollectionLastProductsViewComponent(GetCategoryQueryHandler _getCategoryQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return View(values);
        }
    }
}
