using KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.ServiceQueries;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly GetServiceQueryHandler _getServiceQueryHandler;
        private readonly GetServiceByIdQueryHandler _getServiceByIdQueryHandler;
        public ServiceController(GetServiceQueryHandler getServiceQueryHandler)
        {
            _getServiceQueryHandler = getServiceQueryHandler;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _getServiceQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _getServiceByIdQueryHandler.Handle(new GetServiceByIdQuery(id));
            return View(value);
        }
    }
}


//query işlemleri yapıldı 