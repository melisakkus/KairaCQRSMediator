using AutoMapper;
using KairaCQRSMediator.Features.Mediator.Queries.ProductQueries;
using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using KairaCQRSMediator.Repositories.ProductRepositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class GetRandomProductQueryHandler(IProductService _productService, IMapper _mapper) : IRequestHandler<GetRandomProductQuery, GetRandomProductQueryResult>
    {
        public async Task<GetRandomProductQueryResult> Handle(GetRandomProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetRandomProduct(include: x => x.Category);
            return _mapper.Map<GetRandomProductQueryResult>(product);
        }
    }
}
