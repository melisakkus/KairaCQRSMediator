using KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{
    [ViewComponent(Name = "BrandViewComponent")]
    public class BrandViewComponent(GetBrandQueryHandler _getBrandQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _getBrandQueryHandler.Handle();
            return View(values);
        }
    }

}
