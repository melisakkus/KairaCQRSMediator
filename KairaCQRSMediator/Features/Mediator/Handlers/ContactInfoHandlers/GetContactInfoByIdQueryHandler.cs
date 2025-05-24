using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class GetContactInfoByIdQueryHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<GetContactInfoByIdQuery, GetContactInfoByIdQueryResult>
    {
        public async Task<GetContactInfoByIdQueryResult> Handle(GetContactInfoByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetContactInfoByIdQueryResult>(value);
        }
    }
}
