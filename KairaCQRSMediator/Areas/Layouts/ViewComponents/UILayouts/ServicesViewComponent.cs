using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{
    [ViewComponent(Name = "ServicesViewComponent")]
    public class ServicesViewComponent(GetServiceQueryHandler _getServiceQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _getServiceQueryHandler.Handle();
            return View(values);
        }
    }
}
