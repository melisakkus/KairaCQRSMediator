﻿using KairaCQRSMediator.Features.CQRS.Results.CategoryResults;

namespace KairaCQRSMediator.Features.Mediator.Results.ProductResults
{
    public class GetLastProductsQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public GetCategoryQueryResult Category { get; set; }
    }
}
