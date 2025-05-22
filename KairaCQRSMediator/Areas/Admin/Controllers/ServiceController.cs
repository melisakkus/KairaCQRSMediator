using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.ServiceQueries;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController(GetServiceQueryHandler _getServiceQueryHandler,
                                   GetServiceByIdQueryHandler _getServiceByIdQueryHandler, 
                                   CreateServiceCommandHandler _createServiceCommandHandler,
                                   UpdateServiceCommandHandler _updateServiceCommandHandler,
                                   RemoveServiceCommandHandler _removeServiceCommandHandler) : Controller
    {
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
        [HttpPost]
        public async Task<IActionResult> Update(UpdateServiceCommand command)
        {
            await _updateServiceCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceCommand command)
        {
            await _createServiceCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _removeServiceCommandHandler.Handle(new RemoveServiceCommand(id));
            return RedirectToAction("Index");
        }
    }
}
