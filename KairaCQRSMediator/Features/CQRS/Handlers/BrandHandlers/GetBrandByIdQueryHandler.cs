using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Queries.BrandQueries;
using KairaCQRSMediator.Features.CQRS.Results.BrandResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler(IRepository<Brand> _repository, IMapper _mapper)
    {
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return _mapper.Map<GetBrandByIdQueryResult>(value);
        }

    }
}
