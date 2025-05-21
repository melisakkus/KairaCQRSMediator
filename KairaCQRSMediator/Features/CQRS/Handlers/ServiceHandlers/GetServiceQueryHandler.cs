using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.ServiceResuts;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler(IRepository<Service> _repository)
    {
        public async Task<List<GetServiceQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(select => new GetServiceQueryResult
            {
                ServiceId = select.ServiceId,
                Name = select.Name,
                Description = select.Description,
                Icon = select.Icon,
            }).ToList();
        }
    }
}
