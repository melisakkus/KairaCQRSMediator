using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.CategoryResults;

namespace KairaCQRSMediator.Mappings
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping() 
        {
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
        }
    }
}
