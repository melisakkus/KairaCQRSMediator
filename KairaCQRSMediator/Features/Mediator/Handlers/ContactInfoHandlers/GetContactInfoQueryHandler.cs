using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class GetContactInfoQueryHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<GetContactInfosQuery, List<GetContactInfosQueryResult>>
    {
        public async Task<List<GetContactInfosQueryResult>> Handle(GetContactInfosQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetContactInfosQueryResult>>(values);
        }
    }
}
