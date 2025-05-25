using KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{
    [ViewComponent(Name = "TestimonialViewComponent")]
    public class TestimonialViewComponent(GetTestimonialQueryHandler _getTestimonialQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _getTestimonialQueryHandler.Handle();
            return View(values);
        }
    }

}
