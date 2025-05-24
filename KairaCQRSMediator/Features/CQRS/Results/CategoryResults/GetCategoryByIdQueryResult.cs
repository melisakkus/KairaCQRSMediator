using KairaCQRSMediator.DataAccess.Entities;

namespace KairaCQRSMediator.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
