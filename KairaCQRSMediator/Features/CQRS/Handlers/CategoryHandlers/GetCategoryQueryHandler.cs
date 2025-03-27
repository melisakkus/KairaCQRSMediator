using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.CategoryResults;
using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _categoryRepository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _categoryRepository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Select(category => new GetCategoryQueryResult
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                ImageUrl = category.ImageUrl,
                Products = (IList<GetProductsQueryResult>)category.Products,                
            }).ToList();
        }
    }
}
