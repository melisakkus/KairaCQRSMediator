using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{
    [ViewComponent(Name = "CategoriesViewComponent")]
    public class CategoriesViewComponent(GetCategoryQueryHandler _getCategoryQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return View(values);
        }
    }
}
