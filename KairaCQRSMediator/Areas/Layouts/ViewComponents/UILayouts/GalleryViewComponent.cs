using KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.ViewComponents.UILayouts
{
    [ViewComponent(Name = "GalleryViewComponent")]
    public class GalleryViewComponent(IMediator _mediator) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetGalleriesQuery());
            return View(values);
        }
    }
}
