using KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers;
using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers;
using KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers;

namespace KairaCQRSMediator.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection HandlerServices(this IServiceCollection services)
        {
            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();

            services.AddScoped<GetServiceQueryHandler>();
            services.AddScoped<GetServiceByIdQueryHandler>();
            services.AddScoped<CreateServiceCommandHandler>();
            services.AddScoped<UpdateServiceCommandHandler>();
            services.AddScoped<RemoveServiceCommandHandler>();

            services.AddScoped<GetTestimonialQueryHandler>();
            services.AddScoped<GetTestimonialByIdQueryHandler>();
            services.AddScoped<CreateTestimonialCommandHandler>();
            services.AddScoped<UpdateTestimonialCommandHandler>();
            services.AddScoped<RemoveTestimonialCommandHandler>();

            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();

            return services;
        }
    }
}
