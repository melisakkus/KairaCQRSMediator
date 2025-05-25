using KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{

    [ViewComponent(Name = "Footer_SocialMediaViewComponent")]
    public class Footer_SocialMediaViewComponent(IMediator _mediator) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return View(values);
        }
    }
}
