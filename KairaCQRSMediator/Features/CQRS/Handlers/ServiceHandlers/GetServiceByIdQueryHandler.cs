using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Queries.ServiceQueries;
using KairaCQRSMediator.Features.CQRS.Results.ServiceResuts;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler(IRepository<Service> _repository)
    {
        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceId = value.ServiceId,
                Name = value.Name,
                Description = value.Description,
                Icon = value.Icon
            };
        }
    }
}
