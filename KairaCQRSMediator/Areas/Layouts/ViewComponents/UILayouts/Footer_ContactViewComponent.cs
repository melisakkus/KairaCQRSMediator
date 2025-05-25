using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{
    [ViewComponent(Name = "Footer_ContactViewComponent")]
    public class Footer_ContactViewComponent(IMediator _mediator) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetContactInfosQuery());
            return View(values);
        }
    }
}
