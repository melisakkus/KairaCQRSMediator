using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ProductQueries;
using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using KairaCQRSMediator.Repositories;
using KairaCQRSMediator.Repositories.ProductRepositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class GetLastProductsQueryHandler(IProductService _productService, IMapper _mapper) : IRequestHandler<GetLastProductsQuery, List<GetLastProductsQueryResult>>
    {
        public async Task<List<GetLastProductsQueryResult>> Handle(GetLastProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetLast4Products(include: x => x.Category);
            return _mapper.Map<List<GetLastProductsQueryResult>>(products);
        }
    }
}
