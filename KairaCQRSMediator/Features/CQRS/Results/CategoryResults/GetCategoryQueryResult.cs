using KairaCQRSMediator.Features.Mediator.Results.ProductResults;

namespace KairaCQRSMediator.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public IList<GetProductsQueryResult> Products { get; set; }
    }
}
