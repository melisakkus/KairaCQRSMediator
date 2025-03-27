using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ProductQueries;
using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductsQueryHandler(IRepository<Product> _productRepository, IMapper _mapper) : IRequestHandler<GetProductsQuery, List<GetProductsQueryResult>>
    {
        public async Task<List<GetProductsQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync(include : x=>x.Category);
            return _mapper.Map<List<GetProductsQueryResult>>(products);
        }
    }
}
