using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries;
using KairaCQRSMediator.Features.Mediator.Results.SocialMediaResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler(IRepository<SocialMedia> _repository, IMapper _mapper) : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediasQueryResult>>
    {
        public async Task<List<GetSocialMediasQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetSocialMediasQueryResult>>(values);
        }
    }
}
