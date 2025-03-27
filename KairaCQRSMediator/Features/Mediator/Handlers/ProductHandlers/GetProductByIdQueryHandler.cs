using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ProductQueries;
using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}
